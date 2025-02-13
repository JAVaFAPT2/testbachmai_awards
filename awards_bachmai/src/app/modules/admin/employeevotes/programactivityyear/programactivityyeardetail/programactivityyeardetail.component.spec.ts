import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProgramactivityyeardetailComponent } from './programactivityyeardetail.component';

describe('InspirationalpersonyeardetailComponent', () => {
  let component: ProgramactivityyeardetailComponent;
  let fixture: ComponentFixture<ProgramactivityyeardetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProgramactivityyeardetailComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProgramactivityyeardetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
