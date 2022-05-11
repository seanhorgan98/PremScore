import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MiniFixtureComponent } from './mini-fixture.component';

describe('MiniFixtureComponent', () => {
  let component: MiniFixtureComponent;
  let fixture: ComponentFixture<MiniFixtureComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MiniFixtureComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MiniFixtureComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
