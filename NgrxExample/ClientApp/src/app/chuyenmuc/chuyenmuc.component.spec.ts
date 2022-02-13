import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChuyenmucComponent } from './chuyenmuc.component';

describe('ChuyenmucComponent', () => {
  let component: ChuyenmucComponent;
  let fixture: ComponentFixture<ChuyenmucComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChuyenmucComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ChuyenmucComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
