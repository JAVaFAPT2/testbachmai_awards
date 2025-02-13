import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProgramactivityyearComponent } from './programactivityyear.component';

describe('ProgramactivityyearComponent', () => {
  let component: ProgramactivityyearComponent;
  let fixture: ComponentFixture<ProgramactivityyearComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProgramactivityyearComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProgramactivityyearComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
