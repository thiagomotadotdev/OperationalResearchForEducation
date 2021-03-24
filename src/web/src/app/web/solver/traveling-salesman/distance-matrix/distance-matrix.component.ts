import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { TravelingSalesmanSolverService } from 'src/app/api/traveling-salesman-solver.service';

@Component({
  selector: 'app-distance-matrix',
  templateUrl: './distance-matrix.component.html',
  styleUrls: ['./distance-matrix.component.scss']
})
export class DistanceMatrixComponent implements OnInit {

  public parameters: any;

  public formMatrix: FormControl[][];

  public solution: Observable<any> | undefined;

  constructor(
    private route: ActivatedRoute,
    private formBuilder: FormBuilder,
    private service: TravelingSalesmanSolverService
  ) {
    this.parameters = this.route.snapshot.queryParams;
    console.log(this.parameters.numberOfPoints);
    this.formMatrix = new Array<FormControl[]>();
    for (let i = 0; i < this.parameters.numberOfPoints; i++) {
      const formLine = new Array<FormControl>();
      for (let j = 0; j < this.parameters.numberOfPoints; j++) {
        const control = this.formBuilder.control('', [Validators.required]);
        if (i === j) {
          control.disable();
          control.setValue(0);
        }
        formLine.push(control);
      }
      this.formMatrix.push(formLine);
    }
  }

  isInvalid(): boolean {
    for (let i = 0; i < this.parameters.numberOfPoints; i++) {
      for (let j = 0; j < this.parameters.numberOfPoints; j++) {
        if (this.formMatrix[i][j].invalid) {
          return true;
        }
      }
    }
    return false;
  }

  ngOnInit(): void {
  }

  onSubmit(): void {
    const distanceArrays = new Array<any>();
    for (const formArray of this.formMatrix) {
      const distances = new Array<number>();
      for (const control of formArray) {
        distances.push(Number(control.value));
      }
      distanceArrays.push({ distances });
    }
    const request = {
      numberOfPoints: this.parameters.numberOfPoints,
      startPoint: this.parameters.startPoint,
      firstSolutionStrategy: {
        code: this.parameters.firstSolutionStrategy
      },
      distanceMatrix: {
        distanceArrays
      }
    };

    console.log(JSON.stringify(request));
    this.solution = this.service.solve(request);
  }
}
