import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OpenMessionsComponent } from './open-messions.component';

describe('OpenMessionsComponent', () => {
  let component: OpenMessionsComponent;
  let fixture: ComponentFixture<OpenMessionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OpenMessionsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(OpenMessionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
