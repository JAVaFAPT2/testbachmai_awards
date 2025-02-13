import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DepartmentyearComponent } from './departmentyear.component';

describe('DepartmentyearComponent', () => {
  let component: DepartmentyearComponent;
  let fixture: ComponentFixture<DepartmentyearComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DepartmentyearComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DepartmentyearComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
