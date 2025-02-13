import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProgramactivityyearlistComponent } from './programactivityyearlist.component';

describe('InspirationalpersonyearlistComponent', () => {
  let component: ProgramactivityyearlistComponent;
  let fixture: ComponentFixture<ProgramactivityyearlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProgramactivityyearlistComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProgramactivityyearlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
