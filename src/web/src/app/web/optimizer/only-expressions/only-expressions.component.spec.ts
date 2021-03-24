import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OnlyExpressionsComponent } from './only-expressions.component';

describe('OnlyExpressionsComponent', () => {
  let component: OnlyExpressionsComponent;
  let fixture: ComponentFixture<OnlyExpressionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OnlyExpressionsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OnlyExpressionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
