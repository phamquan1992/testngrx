import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LuotxemComponent } from './luotxem.component';

describe('LuotxemComponent', () => {
  let component: LuotxemComponent;
  let fixture: ComponentFixture<LuotxemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LuotxemComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LuotxemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
