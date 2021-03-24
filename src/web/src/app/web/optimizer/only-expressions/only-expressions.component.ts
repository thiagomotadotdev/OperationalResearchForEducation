import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { OptimizerService } from 'src/app/api/optimizer.service';
import { OptimizerProblem } from 'src/app/models/optimizer-problem';
import { OptimizerSolution } from 'src/app/models/optimizer-solution';
import { OptimizerSolveType } from 'src/app/models/optimizer-solve-type';

@Component({
  selector: 'app-only-expressions',
  templateUrl: './only-expressions.component.html',
  styleUrls: ['./only-expressions.component.scss']
})
export class OnlyExpressionsComponent implements OnInit {

  public variables: FormControl[];

  public restrictionExpressions: FormControl[];

  public solveType: FormControl;

  public objectiveExpression: FormControl;

  public solution$: Observable<OptimizerSolution> | undefined;

  constructor(
    private formBuilder: FormBuilder,
    private route: ActivatedRoute,
    private api: OptimizerService
  ) {
    this.variables = [];
    this.restrictionExpressions = [];
    this.solveType = this.formBuilder.control('', [Validators.required]);
    this.objectiveExpression = this.formBuilder.control('', [Validators.required, Validators.pattern(/^[A-Za-z0-9 =<>*-=]+$/)]);

    const exampleCode = this.route.snapshot.queryParams.exampleCode;

    if (exampleCode) {
      this.api.getExample(exampleCode).subscribe({ next: (reponse) => this.loadExample(reponse) });
    } else {
      this.addNewVariable();
      this.addNewRestrictionExpression();
    }

  }

  loadExample(example: OptimizerProblem): void {
    console.log(example);

    for (const variable of example.variables) {
      this.addNewVariable(variable);
    }
    for (const restrictionExpression of example.restrictionExpressions) {
      this.addNewRestrictionExpression(restrictionExpression);
    }
    this.solveType.setValue(example.solveType.code.toString());
    this.objectiveExpression.setValue(example.objectiveExpression);
  }

  addNewVariable(initialValue: string = ''): void {
    this.variables.push(this.formBuilder.control(initialValue, [Validators.pattern(/^[A-Za-z][A-Za-z0-9=<>*-=]* bool$|^[A-Za-z][A-Za-z0-9=<>*-=]*$/)]));
  }

  addNewRestrictionExpression(initialValue: string = ''): void {
    this.restrictionExpressions.push(this.formBuilder.control(initialValue, [Validators.pattern(/^[A-Za-z0-9 =<>*-=]+$/)]));
  }

  formIsInvalid(): boolean {
    for (const variable of this.variables) {
      if (variable.invalid) {
        return true;
      }
    }
    for (const restrictionExpression of this.restrictionExpressions) {
      if (restrictionExpression.invalid) {
        return true;
      }
    }
    if (this.objectiveExpression.invalid) {
      return true;
    }
    return false;
  }

  solve(): void {
    const variables = [];
    for (const variable of this.variables) {
      variables.push(variable.value);
    }

    const restrictionExpressions = [];
    for (const restrictionExpression of this.restrictionExpressions) {
      restrictionExpressions.push(restrictionExpression.value);
    }

    this.solution$ = this.api.solveWithIntegerOptimizer({
      variables,
      restrictionExpressions,
      solveType: { code: this.solveType.value },
      objectiveExpression: this.objectiveExpression.value
    });
  }

  ngOnInit(): void {
  }
}
