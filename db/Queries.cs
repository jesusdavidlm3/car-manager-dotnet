public static class Queries
{
    public const string newReg = "INSERT INTO regs(id, checkinId, quantity, description, date) VALUES(?, ?, ?, ?, ?)";

    public const string getRegs = "SELECT * FROM regs WHERE checkinId = ?";

    public const string getActiveCars  = @"
        SELECT 
            cars.id as carId,
            cars.brandId,
            cars.modelId,
            checkin.entranceState,
            checkin.id as checkinId,
            checkin.checkinDate,
            checkin.checkoutDate,
            checkin.clientId,
            cars.year,
            cars.plates,
            cars.color
        FROM Checkin INNER JOIN cars ON cars.id = Checkin.carId WHERE checkoutDate IS NULL
    ";

    public const string registerCheckin  = @"
        INSERT INTO Checkin(id, carId, clientId, checkinDate, checkoutDate, entranceState)
        VALUES(?, ?, ?, ?, ?, ?)
    ";

    public const string registerCar = "INSERT INTO cars(id, plates, brandId, modelId, year, color) VALUES(?, ?, ?, ?, ?, ?)";

    public const string checkCarPlate = "SELECT * FROM cars WHERE plates = ?";

    public const string registerClient = "INSERT INTO clients(id, name, phone, address) VALUES(?, ?, ?, ?)";

    public const string checkIdentification = "SELECT * FROM clients WHERE id = ?";

    public const string getAllCarModels = "SELECT * FROM carModels";

    public const string getAllCarBrands = "SELECT * FROM carBrands";

    public const string checkout = "UPDATE checkin SET checkoutDate = ? WHERE id = ?";

    public const string getAllCarChecks = @"
        SELECT 
            checkin.checkinDate,
            checkin.checkoutDate,
            checkin.entranceState,
            checkin.id as checkinId
        FROM cars INNER JOIN checkin
        ON checkin.carId = cars.id
        WHERE cars.plates = ?
    ";

    public const string creationQuery = @"
    CREATE TABLE IF NOT EXISTS cars (
        id text NOT NULL PRIMARY KEY,
        plates text NOT NULL,
        brandId integer NOT NULL,
        modelId integer NOT NULL,
        year text NOT NULL,
        color text NOT NULL,
        FOREIGN KEY (brandId) REFERENCES carBrands (id),
        FOREIGN KEY (modelId) REFERENCES carModels (id)
    );

    CREATE TABLE IF NOT EXISTS carBrands (
        id integer NOT NULL PRIMARY KEY,
        name text
    );

    CREATE TABLE IF NOT EXISTS carModels (
        id integer NOT NULL PRIMARY KEY,
        brandId integer,
        name text,
        FOREIGN KEY (brandId) REFERENCES carBrands (id)
    );

    CREATE TABLE IF NOT EXISTS clients (
        id text NOT NULL PRIMARY KEY,
        name text NOT NULL,
        phone text NOT NULL,
        address text NOT NULL
    );

    CREATE TABLE IF NOT EXISTS checkin (
        id text NOT NULL PRIMARY KEY,
        carId text NOT NULL,
        clientId text NOT NULL,
        checkinDate datetime NOT NULL,
        checkoutDate datetime,
        entranceState text,
        FOREIGN KEY (carId) REFERENCES cars (id),
        FOREIGN KEY (clientId) REFERENCES clients (id)
    );

    CREATE TABLE IF NOT EXISTS regs (
        id text NOT NULL PRIMARY KEY,
        checkinId text NOT NULL,
        quantity integer,
        description text NOT NULL,
        date datetime NOT NULL, 
        FOREIGN KEY (checkinId) REFERENCES Checkin (id)
    );

    -- Insertar marcas de automóviles
    INSERT OR IGNORE INTO carBrands (id, name) VALUES
    (1, 'Chevrolet'),
    (2, 'Ford'),
    (3, 'Toyota'),
    (4, 'Jeep'),
    (5, 'Kia'),
    (6, 'Hyundai'),
    (7, 'Honda'),
    (8, 'Nissan'),
    (9, 'Mazda'),
    (10, 'Subaru'),
    (11, 'Mitsubishi'),
    (12, 'BMW'),
    (13, 'Mercedes-Benz'),
    (14, 'Volkswagen'),
    (15, 'Audi');

    -- Insertar modelos de automóviles para Chevrolet
    INSERT OR IGNORE INTO carModels (id, brandId, name) VALUES
    (1, 1, 'Aveo'),
    (2, 1, 'Spark'),
    (3, 1, 'Cruze'),
    (4, 1, 'Malibu'),
    (5, 1, 'Impala'),
    (6, 1, 'Silverado'),
    (7, 1, 'Traverse'),
    (8, 1, 'Equinox'),
    (9, 1, 'Tahoe'),
    (10, 1, 'Suburban'),
    (11, 1, 'Colorado'),
    (12, 1, 'Express'),
    (13, 1, 'Sonic'),
    (14, 1, 'HHR'),
    (15, 1, 'Volt');

    -- Insertar modelos de automóviles para Ford
    INSERT OR IGNORE INTO carModels (id, brandId, name) VALUES
    (16, 2, 'F150'),
    (17, 2, 'F250'),
    (18, 2, 'F350'),
    (19, 2, 'F450'),
    (20, 2, 'F550'),
    (21, 2, 'Explorer'),
    (22, 2, 'Escape'),
    (23, 2, 'Mustang'),
    (24, 2, 'Focus'),
    (25, 2, 'Taurus'),
    (26, 2, 'Fiesta'),
    (27, 2, 'Bronco'),
    (28, 2, 'Ranger'),
    (29, 2, 'Edge'),
    (30, 2, 'Expedition');

    -- Insertar modelos de automóviles para Toyota
    INSERT OR IGNORE INTO carModels (id, brandId, name) VALUES
    (31, 3, 'Corolla'),
    (32, 3, 'Camry'),
    (33, 3, 'RAV4'),
    (34, 3, 'Highlander'),
    (35, 3, 'Tacoma'),
    (36, 3, 'Prius'),
    (37, 3, 'Sienna'),
    (38, 3, 'C-HR'),
    (39, 3, 'Land Cruiser'),
    (40, 3, '4Runner'),
    (41, 3, 'Sequoia'),
    (42, 3, 'Yaris'),
    (43, 3, 'Avalon'),
    (44, 3, 'Mirai'),
    (45, 3, 'GR86'),
    (46, 3, 'GR Supra');

    -- Insertar modelos de automóviles para Jeep
    INSERT OR IGNORE INTO carModels (id, brandId, name) VALUES
    (47, 4, 'Grand Cherokee'),
    (48, 4, 'Cherokee'),
    (49, 4, 'Wrangler'),
    (50, 4, 'Renegade'),
    (51, 4, 'Compass'),
    (52, 4, 'Gladiator'),
    (53, 4, 'Wagoneer'),
    (54, 4, 'Liberty'),
    (55, 4, 'Commander'),
    (56, 4, 'Patriot'),
    (57, 4, 'Hurricane'),
    (58, 4, 'CJ'),
    (59, 4, 'Renegade'),
    (60, 4, 'Willys'),
    (61, 4, 'J-Series'),
    (62, 4, 'DJ-5');

    -- Insertar modelos de automóviles para Kia
    INSERT OR IGNORE INTO carModels (id, brandId, name) VALUES
    (63, 5, 'Rio'),
    (64, 5, 'Soul'),
    (65, 5, 'Optima'),
    (66, 5, 'Sorento'),
    (67, 5, 'Sportage'),
    (68, 5, 'Cadenza'),
    (69, 5, 'K5'),
    (70, 5, 'Telluride'),
    (71, 5, 'Niro'),
    (72, 5, 'Forte'),
    (73, 5, 'Kona'),
    (74, 5, 'K5'),
    (75, 5, 'K7'),
    (76, 5, 'K3'),
    (77, 5, 'K4');

    -- Insertar modelos de automóviles para Hyundai
    INSERT OR IGNORE INTO carModels (id, brandId, name) VALUES
    (78, 6, 'Elantra'),
    (79, 6, 'Accent'),
    (80, 6, 'Tucson'),
    (81, 6, 'Santa Fe'),
    (82, 6, 'Sonata'),
    (83, 6, 'Veloster'),
    (84, 6, 'Palisade'),
    (85, 6, 'Ioniq'),
    (86, 6, 'Genesis'),
    (87, 6, 'Kona'),
    (88, 6, 'Nexo'),
    (89, 6, 'Venue'),
    (90, 6, 'Azera'),
    (91, 6, 'Getz'),
    (92, 6, 'i30'),
    (93, 6, 'i40');

    -- Insertar modelos de automóviles para Honda
    INSERT OR IGNORE INTO carModels (id, brandId, name) VALUES
    (94, 7, 'Civic'),
    (95, 7, 'Accord'),
    (96, 7, 'CR-V'),
    (97, 7, 'HR-V'),
    (98, 7, 'Pilot'),
    (99, 7, 'Odyssey'),
    (100, 7, 'Fit'),
    (101, 7, 'Insight'),
    (102, 7, 'Passport'),
    (103, 7, 'Clarity'),
    (104, 7, 'Ridgeline'),
    (105, 7, 'Element'),
    (106, 7, 'S2000'),
    (107, 7, 'City'),
    (108, 7, 'Jazz');

    -- Insertar modelos de automóviles para Nissan
    INSERT OR IGNORE INTO carModels (id, brandId, name) VALUES
    (109, 8, 'Altima'),
    (110, 8, 'Maxima'),
    (111, 8, 'Sentra'),
    (112, 8, 'Versa'),
    (113, 8, 'Pathfinder'),
    (114, 8, 'Murano'),
    (115, 8, 'Juke'),
    (116, 8, 'Kicks'),
    (117, 8, 'Leaf'),
    (118, 8, 'Armada'),
    (119, 8, 'Titan'),
    (120, 8, 'Xterra'),
    (121, 8, 'Quest'),
    (122, 8, 'Cube'),
    (123, 8, 'Rogue');
    ";
}