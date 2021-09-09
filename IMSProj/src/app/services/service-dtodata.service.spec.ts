import { TestBed } from '@angular/core/testing';

import { ServiceDtodataService } from './service-dtodata.service';

describe('ServiceDtodataService', () => {
  let service: ServiceDtodataService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServiceDtodataService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
