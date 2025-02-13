import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DepartmentleaderyeardetailComponent } from './departmentleaderyeardetail.component';

describe('DepartmentleaderyeardetailComponent', () => {
  let component: DepartmentleaderyeardetailComponent;
  let fixture: ComponentFixture<DepartmentleaderyeardetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DepartmentleaderyeardetailComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DepartmentleaderyeardetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
