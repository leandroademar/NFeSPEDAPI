CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

START TRANSACTION;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20250411014058_Initial') THEN
    CREATE TABLE nfes (
        "Id" uuid NOT NULL,
        chave_acesso text NOT NULL,
        numero text NOT NULL,
        serie text NOT NULL,
        data_emissao timestamp with time zone NOT NULL,
        valor_total numeric NOT NULL,
        cnpj_emitente text NOT NULL,
        nome_emitente text NOT NULL,
        cnpj_destinatario text NOT NULL,
        nome_destinatario text NOT NULL,
        data_importacao timestamp with time zone NOT NULL,
        xml_completo text NOT NULL,
        CONSTRAINT "PK_nfes" PRIMARY KEY ("Id")
    );
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20250411014058_Initial') THEN
    CREATE TABLE sped_arquivos (
        "Id" uuid NOT NULL,
        cnpj text NOT NULL,
        nome_empresa text NOT NULL,
        periodo_inicial timestamp with time zone NOT NULL,
        periodo_final timestamp with time zone NOT NULL,
        data_importacao timestamp with time zone NOT NULL,
        arquivo_completo text NOT NULL,
        CONSTRAINT "PK_sped_arquivos" PRIMARY KEY ("Id")
    );
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20250411014058_Initial') THEN
    CREATE TABLE nfe_itens (
        "Id" uuid NOT NULL,
        nfe_id uuid NOT NULL,
        numero_item integer NOT NULL,
        codigo_produto text NOT NULL,
        descricao text NOT NULL,
        ncm text NOT NULL,
        cfop text NOT NULL,
        unidade text NOT NULL,
        quantidade numeric NOT NULL,
        valor_unitario numeric NOT NULL,
        valor_total numeric NOT NULL,
        valor_icms numeric NOT NULL,
        valor_ipi numeric NOT NULL,
        CONSTRAINT "PK_nfe_itens" PRIMARY KEY ("Id"),
        CONSTRAINT "FK_nfe_itens_nfes_nfe_id" FOREIGN KEY (nfe_id) REFERENCES nfes ("Id") ON DELETE CASCADE
    );
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20250411014058_Initial') THEN
    CREATE TABLE sped_blocos (
        "Id" uuid NOT NULL,
        sped_id uuid NOT NULL,
        codigo_bloco text NOT NULL,
        descricao text NOT NULL,
        CONSTRAINT "PK_sped_blocos" PRIMARY KEY ("Id"),
        CONSTRAINT "FK_sped_blocos_sped_arquivos_sped_id" FOREIGN KEY (sped_id) REFERENCES sped_arquivos ("Id") ON DELETE CASCADE
    );
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20250411014058_Initial') THEN
    CREATE TABLE sped_registros (
        "Id" uuid NOT NULL,
        bloco_id uuid NOT NULL,
        codigo_registro text NOT NULL,
        conteudo text NOT NULL,
        linha_arquivo integer NOT NULL,
        CONSTRAINT "PK_sped_registros" PRIMARY KEY ("Id"),
        CONSTRAINT "FK_sped_registros_sped_blocos_bloco_id" FOREIGN KEY (bloco_id) REFERENCES sped_blocos ("Id") ON DELETE CASCADE
    );
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20250411014058_Initial') THEN
    CREATE INDEX "IX_nfe_itens_nfe_id" ON nfe_itens (nfe_id);
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20250411014058_Initial') THEN
    CREATE INDEX "IX_sped_blocos_sped_id" ON sped_blocos (sped_id);
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20250411014058_Initial') THEN
    CREATE INDEX "IX_sped_registros_bloco_id" ON sped_registros (bloco_id);
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20250411014058_Initial') THEN
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20250411014058_Initial', '9.0.4');
    END IF;
END $EF$;
COMMIT;

