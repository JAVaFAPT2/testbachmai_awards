import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DepartmentleaderyearlistComponent } from './departmentleaderyearlist.component';

describe('InspirationalpersonyearlistComponent', () => {
  let component: DepartmentleaderyearlistComponent;
  let fixture: ComponentFixture<DepartmentleaderyearlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DepartmentleaderyearlistComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DepartmentleaderyearlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
