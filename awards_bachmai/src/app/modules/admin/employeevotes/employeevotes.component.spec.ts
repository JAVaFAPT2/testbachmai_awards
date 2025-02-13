import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeevotesComponent } from './employeevotes.component';

describe('EmployeevotesComponent', () => {
  let component: EmployeevotesComponent;
  let fixture: ComponentFixture<EmployeevotesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EmployeevotesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EmployeevotesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
