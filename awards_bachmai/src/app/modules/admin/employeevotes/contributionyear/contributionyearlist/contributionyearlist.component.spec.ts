import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContributionyearlistComponent } from './contributionyearlist.component';

describe('InspirationalpersonyearlistComponent', () => {
  let component: ContributionyearlistComponent;
  let fixture: ComponentFixture<ContributionyearlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ContributionyearlistComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ContributionyearlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
