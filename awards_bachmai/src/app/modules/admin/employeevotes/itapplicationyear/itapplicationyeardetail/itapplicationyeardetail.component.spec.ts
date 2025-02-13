import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ItapplicationyeardetailComponent } from './itapplicationyeardetail.component';

describe('InspirationalpersonyeardetailComponent', () => {
  let component: ItapplicationyeardetailComponent;
  let fixture: ComponentFixture<ItapplicationyeardetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ItapplicationyeardetailComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ItapplicationyeardetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
