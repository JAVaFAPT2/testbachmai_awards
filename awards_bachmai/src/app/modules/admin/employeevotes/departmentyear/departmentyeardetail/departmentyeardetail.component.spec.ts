import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DepartmentyeardetailComponent } from './departmentyeardetail.component';

describe('InspirationalpersonyeardetailComponent', () => {
  let component: DepartmentyeardetailComponent;
  let fixture: ComponentFixture<DepartmentyeardetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DepartmentyeardetailComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DepartmentyeardetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
