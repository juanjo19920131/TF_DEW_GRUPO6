import { TestBed } from '@angular/core/testing';

import { UsadoService } from './usado.service';

describe('UsadoService', () => {
  let service: UsadoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UsadoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
