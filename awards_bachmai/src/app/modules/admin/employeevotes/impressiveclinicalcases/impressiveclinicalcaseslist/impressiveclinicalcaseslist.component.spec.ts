import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ImpressiveclinicalcaseslistComponent } from './impressiveclinicalcaseslist.component';

describe('InspirationalpersonyearlistComponent', () => {
  let component: ImpressiveclinicalcaseslistComponent;
  let fixture: ComponentFixture<ImpressiveclinicalcaseslistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ImpressiveclinicalcaseslistComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ImpressiveclinicalcaseslistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
