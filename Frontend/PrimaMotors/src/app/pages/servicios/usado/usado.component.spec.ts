import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UsadoComponent } from './usado.component';

describe('UsadoComponent', () => {
  let component: UsadoComponent;
  let fixture: ComponentFixture<UsadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UsadoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UsadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
