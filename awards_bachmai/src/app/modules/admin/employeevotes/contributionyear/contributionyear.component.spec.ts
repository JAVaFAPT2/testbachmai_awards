import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContributionyearComponent } from './contributionyear.component';

describe('ContributionyearComponent', () => {
  let component: ContributionyearComponent;
  let fixture: ComponentFixture<ContributionyearComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ContributionyearComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ContributionyearComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
