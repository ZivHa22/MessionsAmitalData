import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MessionComponent } from './mession.component';

describe('MessionComponent', () => {
  let component: MessionComponent;
  let fixture: ComponentFixture<MessionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MessionComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MessionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
