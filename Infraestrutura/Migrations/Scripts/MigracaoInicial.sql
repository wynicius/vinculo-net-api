CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    migration_id character varying(150) NOT NULL,
    product_version character varying(32) NOT NULL,
    CONSTRAINT pk___ef_migrations_history PRIMARY KEY (migration_id)
);

START TRANSACTION;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM pg_namespace WHERE nspname = 'vinculo_net') THEN
        CREATE SCHEMA vinculo_net;
    END IF;
END $EF$;

CREATE TABLE vinculo_net.candidaturas (
    candidatura_id uuid NOT NULL,
    voluntario_id uuid NOT NULL,
    projeto_id uuid NOT NULL,
    data timestamp with time zone NOT NULL,
    status integer NOT NULL,
    usuario_cadastro text NULL,
    usuario_atualizacao text NULL,
    data_cadastro timestamp with time zone NOT NULL,
    data_atualizacao timestamp with time zone NOT NULL,
    CONSTRAINT pk_candidaturas PRIMARY KEY (candidatura_id)
);

CREATE TABLE vinculo_net.habilidades (
    habilidade_id uuid NOT NULL,
    nome text NULL,
    descricao text NULL,
    usuario_cadastro text NULL,
    usuario_atualizacao text NULL,
    data_cadastro timestamp with time zone NOT NULL,
    data_atualizacao timestamp with time zone NOT NULL,
    CONSTRAINT pk_habilidades PRIMARY KEY (habilidade_id)
);

CREATE TABLE vinculo_net.localizacoes (
    localizacao_id uuid NOT NULL,
    rua text NULL,
    numero integer NOT NULL,
    complemento text NULL,
    cidade text NULL,
    estado text NULL,
    pais text NULL,
    cep text NULL,
    usuario_cadastro text NULL,
    usuario_atualizacao text NULL,
    data_cadastro timestamp with time zone NOT NULL,
    data_atualizacao timestamp with time zone NOT NULL,
    CONSTRAINT pk_localizacoes PRIMARY KEY (localizacao_id)
);

CREATE TABLE vinculo_net.usuarios (
    usuario_id uuid NOT NULL,
    localizacao_id uuid NOT NULL,
    nome text NULL,
    sobrenome text NULL,
    nome_completo text NULL,
    data_nascimento timestamp with time zone NOT NULL,
    cpf text NULL,
    genero character(1) NULL,
    email text NULL,
    telefone text NULL,
    usuario_cadastro text NULL,
    usuario_atualizacao text NULL,
    data_cadastro timestamp with time zone NOT NULL,
    data_atualizacao timestamp with time zone NOT NULL,
    CONSTRAINT pk_usuarios PRIMARY KEY (usuario_id),
    CONSTRAINT fk_usuarios_localizacoes_localizacao_id FOREIGN KEY (localizacao_id) REFERENCES vinculo_net.localizacoes (localizacao_id) ON DELETE RESTRICT
);

CREATE TABLE vinculo_net.investidores (
    investidor_id uuid NOT NULL,
    usuario_id uuid NOT NULL,
    localizacao_id uuid NOT NULL,
    tipo_investidor integer NOT NULL,
    status integer NOT NULL,
    nome_fantasia text NULL,
    razao_social text NULL,
    email text NULL,
    descricao text NULL,
    cnpj text NULL,
    usuario_cadastro text NULL,
    usuario_atualizacao text NULL,
    data_cadastro timestamp with time zone NOT NULL,
    data_atualizacao timestamp with time zone NOT NULL,
    CONSTRAINT pk_investidores PRIMARY KEY (investidor_id),
    CONSTRAINT fk_investidores_localizacoes_localizacao_id FOREIGN KEY (localizacao_id) REFERENCES vinculo_net.localizacoes (localizacao_id) ON DELETE RESTRICT,
    CONSTRAINT fk_investidores_usuarios_usuario_id FOREIGN KEY (usuario_id) REFERENCES vinculo_net.usuarios (usuario_id) ON DELETE RESTRICT
);

CREATE TABLE vinculo_net.voluntarios (
    voluntario_id uuid NOT NULL,
    usuario_id uuid NOT NULL,
    status integer NOT NULL,
    descricao text NULL,
    experiencia text NULL,
    formacao text NULL,
    disponibilidade text NULL,
    habilidades_habilidade_id uuid NULL,
    localizacao_id uuid NULL,
    usuario_cadastro text NULL,
    usuario_atualizacao text NULL,
    data_cadastro timestamp with time zone NOT NULL,
    data_atualizacao timestamp with time zone NOT NULL,
    CONSTRAINT pk_voluntarios PRIMARY KEY (voluntario_id),
    CONSTRAINT fk_voluntarios_habilidades_habilidades_habilidade_id FOREIGN KEY (habilidades_habilidade_id) REFERENCES vinculo_net.habilidades (habilidade_id),
    CONSTRAINT fk_voluntarios_localizacoes_localizacao_id FOREIGN KEY (localizacao_id) REFERENCES vinculo_net.localizacoes (localizacao_id),
    CONSTRAINT fk_voluntarios_usuarios_usuario_id FOREIGN KEY (usuario_id) REFERENCES vinculo_net.usuarios (usuario_id) ON DELETE RESTRICT
);

CREATE TABLE vinculo_net.ongs (
    ong_id uuid NOT NULL,
    localizacao_id uuid NOT NULL,
    status_ong integer NOT NULL,
    nome text NULL,
    cnpj text NULL,
    data_fundacao timestamp with time zone NOT NULL,
    missao text NULL,
    telefone integer NOT NULL,
    email text NULL,
    historico text NULL,
    website text NULL,
    voluntario_id uuid NULL,
    usuario_cadastro text NULL,
    usuario_atualizacao text NULL,
    data_cadastro timestamp with time zone NOT NULL,
    data_atualizacao timestamp with time zone NOT NULL,
    CONSTRAINT pk_ongs PRIMARY KEY (ong_id),
    CONSTRAINT fk_ongs_localizacoes_localizacao_id FOREIGN KEY (localizacao_id) REFERENCES vinculo_net.localizacoes (localizacao_id) ON DELETE RESTRICT,
    CONSTRAINT fk_ongs_voluntarios_voluntario_id FOREIGN KEY (voluntario_id) REFERENCES vinculo_net.voluntarios (voluntario_id)        
);

CREATE TABLE vinculo_net.causas (
    causa_id uuid NOT NULL,
    nome text NULL,
    descricao text NULL,
    investidor_id uuid NULL,
    ong_id uuid NULL,
    voluntario_id uuid NULL,
    usuario_cadastro text NULL,
    usuario_atualizacao text NULL,
    data_cadastro timestamp with time zone NOT NULL,
    data_atualizacao timestamp with time zone NOT NULL,
    CONSTRAINT pk_causas PRIMARY KEY (causa_id),
    CONSTRAINT fk_causas_investidores_investidor_id FOREIGN KEY (investidor_id) REFERENCES vinculo_net.investidores (investidor_id),   
    CONSTRAINT fk_causas_ongs_ong_id FOREIGN KEY (ong_id) REFERENCES vinculo_net.ongs (ong_id),
    CONSTRAINT fk_causas_voluntarios_voluntario_id FOREIGN KEY (voluntario_id) REFERENCES vinculo_net.voluntarios (voluntario_id)      
);

CREATE TABLE vinculo_net.projetos (
    projeto_id uuid NOT NULL,
    ong_id uuid NOT NULL,
    status_projeto integer NOT NULL,
    nome text NULL,
    descricao text NULL,
    objetivos text NULL,
    metas text NULL,
    orcamento integer NOT NULL,
    data_inicio timestamp with time zone NOT NULL,
    data_termino timestamp with time zone NOT NULL,
    causa_id uuid NULL,
    usuario_cadastro text NULL,
    usuario_atualizacao text NULL,
    data_cadastro timestamp with time zone NOT NULL,
    data_atualizacao timestamp with time zone NOT NULL,
    CONSTRAINT pk_projetos PRIMARY KEY (projeto_id),
    CONSTRAINT fk_projetos_causas_causa_id FOREIGN KEY (causa_id) REFERENCES vinculo_net.causas (causa_id),
    CONSTRAINT fk_projetos_ongs_ong_id FOREIGN KEY (ong_id) REFERENCES vinculo_net.ongs (ong_id) ON DELETE RESTRICT
);

CREATE TABLE vinculo_net.investimentos (
    investimento_id uuid NOT NULL,
    investidor_id uuid NOT NULL,
    projeto_id uuid NOT NULL,
    valor numeric NOT NULL,
    data timestamp with time zone NOT NULL,
    usuario_cadastro text NULL,
    usuario_atualizacao text NULL,
    data_cadastro timestamp with time zone NOT NULL,
    data_atualizacao timestamp with time zone NOT NULL,
    CONSTRAINT pk_investimentos PRIMARY KEY (investimento_id),
    CONSTRAINT fk_investimentos_projetos_projeto_id FOREIGN KEY (projeto_id) REFERENCES vinculo_net.projetos (projeto_id) ON DELETE RESTRICT
);

CREATE TABLE vinculo_net.projeto_voluntario (
    projetos_projeto_id uuid NOT NULL,
    voluntarios_voluntario_id uuid NOT NULL,
    CONSTRAINT pk_projeto_voluntario PRIMARY KEY (projetos_projeto_id, voluntarios_voluntario_id),
    CONSTRAINT fk_projeto_voluntario_projetos_projetos_projeto_id FOREIGN KEY (projetos_projeto_id) REFERENCES vinculo_net.projetos (projeto_id) ON DELETE RESTRICT,
    CONSTRAINT fk_projeto_voluntario_voluntarios_voluntarios_voluntario_id FOREIGN KEY (voluntarios_voluntario_id) REFERENCES vinculo_net.voluntarios (voluntario_id) ON DELETE RESTRICT
);

CREATE INDEX ix_causas_investidor_id ON vinculo_net.causas (investidor_id);

CREATE INDEX ix_causas_ong_id ON vinculo_net.causas (ong_id);

CREATE INDEX ix_causas_voluntario_id ON vinculo_net.causas (voluntario_id);

CREATE INDEX ix_investidores_localizacao_id ON vinculo_net.investidores (localizacao_id);

CREATE INDEX ix_investidores_usuario_id ON vinculo_net.investidores (usuario_id);

CREATE INDEX ix_investimentos_projeto_id ON vinculo_net.investimentos (projeto_id);

CREATE INDEX ix_ongs_localizacao_id ON vinculo_net.ongs (localizacao_id);

CREATE INDEX ix_ongs_voluntario_id ON vinculo_net.ongs (voluntario_id);

CREATE INDEX ix_projeto_voluntario_voluntarios_voluntario_id ON vinculo_net.projeto_voluntario (voluntarios_voluntario_id);

CREATE INDEX ix_projetos_causa_id ON vinculo_net.projetos (causa_id);

CREATE INDEX ix_projetos_ong_id ON vinculo_net.projetos (ong_id);

CREATE INDEX ix_usuarios_localizacao_id ON vinculo_net.usuarios (localizacao_id);

CREATE INDEX ix_voluntarios_habilidades_habilidade_id ON vinculo_net.voluntarios (habilidades_habilidade_id);

CREATE INDEX ix_voluntarios_localizacao_id ON vinculo_net.voluntarios (localizacao_id);

CREATE INDEX ix_voluntarios_usuario_id ON vinculo_net.voluntarios (usuario_id);

INSERT INTO "__EFMigrationsHistory" (migration_id, product_version)
VALUES ('20240612174546_MigracaoInicial', '6.0.21');

COMMIT;