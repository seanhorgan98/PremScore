import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LinebreakComponent } from './linebreak.component';

describe('LinebreakComponent', () => {
  let component: LinebreakComponent;
  let fixture: ComponentFixture<LinebreakComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LinebreakComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LinebreakComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
