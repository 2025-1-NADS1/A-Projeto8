
-- Criar o banco de dados (sem espaços no nome físico)
CREATE DATABASE IF NOT EXISTS dashboard_db;
USE dashboard_db;

-- Tabela: usuario
CREATE TABLE usuario (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    telefone VARCHAR(20)
);

-- Tabela: dispositivos
CREATE TABLE dispositivos (
    id_disp INT AUTO_INCREMENT PRIMARY KEY,
    aparelhos VARCHAR(100),
    ar_condicionado BOOLEAN DEFAULT FALSE,
    luzes BOOLEAN DEFAULT FALSE,
    cameras BOOLEAN DEFAULT FALSE,
    id_usuario INT,
    FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario)
);

-- Tabela: sensores
CREATE TABLE sensores (
    id_sensor INT AUTO_INCREMENT PRIMARY KEY,
    sensor_presenca BOOLEAN DEFAULT FALSE,
    sensor_temp FLOAT,
    sensor_voz BOOLEAN DEFAULT FALSE,
    id_disp INT,
    FOREIGN KEY (id_disp) REFERENCES dispositivos(id_disp)
);

-- Tabela: dashboard
CREATE TABLE dashboard (
    id_dashboard INT AUTO_INCREMENT PRIMARY KEY,
    avisos TEXT,
    correcoes TEXT,
    funcionalidades TEXT,
    preferencias TEXT,
    id_usuario INT,
    FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario)
);

-- Tabela: finalidades
CREATE TABLE finalidades (
    id_results INT AUTO_INCREMENT PRIMARY KEY,
    avisos TEXT,
    informacao TEXT,
    manutencao TEXT,
    id_dashboard INT,
    FOREIGN KEY (id_dashboard) REFERENCES dashboard(id_dashboard)
);

-- Inserindo dados na tabela usuario
INSERT INTO usuario (nome, email, telefone) VALUES
('João Silva', 'joao@email.com', '11999999999'),
('Maria Oliveira', 'maria@email.com', '11888888888'),
('Carlos Mendes', 'carlos@email.com', '11777777777');

-- Inserindo dados na tabela dispositivos
INSERT INTO dispositivos (aparelhos, ar_condicionado, luzes, cameras, id_usuario) VALUES
('Controle Central Sala', TRUE, TRUE, TRUE, 1),
('Painel Quarto', FALSE, TRUE, FALSE, 2),
('Estação Cozinha', TRUE, TRUE, TRUE, 3);

-- Inserindo dados na tabela sensores
INSERT INTO sensores (sensor_presenca, sensor_temp, sensor_voz, id_disp) VALUES
(TRUE, 23.5, FALSE, 1),
(FALSE, 19.2, TRUE, 2),
(TRUE, 25.1, TRUE, 3);

-- Inserindo dados na tabela dashboard
INSERT INTO dashboard (avisos, correcoes, funcionalidades, preferencias, id_usuario) VALUES
('Porta da sala aberta', 'Fechar automaticamente após 5 min', 'Monitoramento de entrada', 'Alertas por som', 1),
('Janela do quarto aberta', 'Avisar se estiver chovendo', 'Controle de janelas', 'Alertas por e-mail', 2),
('Temperatura alta na cozinha', 'Ativar exaustor', 'Monitoramento térmico', 'Relatórios semanais', 3);

-- Inserindo dados na tabela finalidades
INSERT INTO finalidades (avisos, informacao, manutencao, id_dashboard) VALUES
('Detector de presença acionado', 'Informar usuário sobre movimentação', 'Verificar sensores trimestralmente', 1),
('Temperatura fora do ideal', 'Informar e ajustar climatização', 'Limpeza nos sensores de temperatura', 2),
('Som detectado em horário incomum', 'Enviar notificação de segurança', 'Atualizar firmware', 3);
