import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ItapplicationyearComponent } from './itapplicationyear.component';

describe('InspirationalpersonyearComponent', () => {
  let component: ItapplicationyearComponent;
  let fixture: ComponentFixture<ItapplicationyearComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ItapplicationyearComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ItapplicationyearComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
