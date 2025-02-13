import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ImpressiveclinicalcasesComponent } from './impressiveclinicalcases.component';

describe('ImpressiveclinicalcasesComponent', () => {
  let component: ImpressiveclinicalcasesComponent;
  let fixture: ComponentFixture<ImpressiveclinicalcasesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ImpressiveclinicalcasesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ImpressiveclinicalcasesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
