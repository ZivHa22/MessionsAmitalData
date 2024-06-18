import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MessionTicketComponent } from './mession-ticket.component';

describe('MessionTicketComponent', () => {
  let component: MessionTicketComponent;
  let fixture: ComponentFixture<MessionTicketComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MessionTicketComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MessionTicketComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
