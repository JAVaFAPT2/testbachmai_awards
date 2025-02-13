import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ScientificresearchyeardetailComponent } from './scientificresearchyeardetail.component';

describe('InspirationalpersonyeardetailComponent', () => {
  let component: ScientificresearchyeardetailComponent;
  let fixture: ComponentFixture<ScientificresearchyeardetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ScientificresearchyeardetailComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ScientificresearchyeardetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
