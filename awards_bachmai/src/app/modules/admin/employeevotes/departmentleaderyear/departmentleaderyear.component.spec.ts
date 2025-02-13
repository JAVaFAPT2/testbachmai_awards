import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DepartmentleaderyearComponent } from './departmentleaderyear.component';

describe('DepartmentleaderyearComponent', () => {
  let component: DepartmentleaderyearComponent;
  let fixture: ComponentFixture<DepartmentleaderyearComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DepartmentleaderyearComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DepartmentleaderyearComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
