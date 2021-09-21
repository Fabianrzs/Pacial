import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ClienteRegistrarAbonoComponent } from './cliente-registrar-abono.component';

describe('ClienteRegistrarAbonoComponent', () => {
  let component: ClienteRegistrarAbonoComponent;
  let fixture: ComponentFixture<ClienteRegistrarAbonoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ClienteRegistrarAbonoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ClienteRegistrarAbonoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
