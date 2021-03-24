import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { FirstSolutionStrategy } from 'src/app/models/first-solution-strategy';
import { TravelingSalesmanSolverService } from '../../../../api/traveling-salesman-solver.service';

@Component({
  selector: 'app-parameters',
  templateUrl: './parameters.component.html',
  styleUrls: ['./parameters.component.scss']
})
export class ParametersComponent implements OnInit {

  public firstSolutionStrategies: Observable<FirstSolutionStrategy[]> | undefined;

  public formGroup: FormGroup;

  constructor(
    private service: TravelingSalesmanSolverService,
    private formBuilder: FormBuilder,
    private router: Router,
    private route: ActivatedRoute
  ) {
    this.formGroup = this.formBuilder.group({
      numberOfPoints: this.formBuilder.control('', [Validators.required]),
      startPoint: this.formBuilder.control('', [Validators.required]),
      firstSolutionStrategy: this.formBuilder.control('', [Validators.required])
    });
  }

  ngOnInit(): void {
    this.firstSolutionStrategies = this.service.getFirstSolutionStrategies();
  }

  onSubmit(): void {
    this.router.navigate(['../distance-matrix'], {
      relativeTo: this.route,
      queryParams: {
        numberOfPoints: this.formGroup.get('numberOfPoints')?.value,
        startPoint: this.formGroup.get('startPoint')?.value,
        firstSolutionStrategy: this.formGroup.get('firstSolutionStrategy')?.value
      }
    });
  }

}
