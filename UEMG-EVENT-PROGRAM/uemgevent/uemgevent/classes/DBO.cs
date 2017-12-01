using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace uemgevent.classes
{
    class DBO
    {
        public SQLiteConnection Conn;
        public string StringConn;
        public string DBName;
        public SQLiteCommand CMD;
        public SQLiteDataReader DataReader;
        public Hash hw;

        public DBO()
        {
            this.SetConn();
        }

        public void SetConn(string db = "uemgevent")
        {
            Conn = new SQLiteConnection();
            this.SetDBName(db);
            this.SetStringConn();
            Conn.ConnectionString = this.GetStringConn();
        }

        public void SetDBName(string DB)
        {
            this.DBName = DB;
        }

        public String GetDBName()
        {
            return this.DBName;
        }

        public String GetStringConn()
        {
            return this.StringConn;
        }

        public void SetStringConn()
        {
            this.StringConn = "Data Source=" + this.GetDBName() + ".db;Version=3;New=True;Compress=True;";
        }

        public void SetCMD(string query)
        {
            this.CMD = this.Conn.CreateCommand();
            this.CMD.CommandText = query;
        }

        public void SetReader()
        {
            this.OpenConnection();
            this.DataReader = this.CMD.ExecuteReader();
        }

        public void SetWriter()
        {
            this.OpenConnection();
            this.CMD.ExecuteNonQuery();
        }

        public void OpenConnection()
        {
            this.Conn.Open();
        }

        public void CloseConnection()
        {
            this.Conn.Close();
        }

        public Int32 LastField(string table, string field)
        {
            string query = "SELECT * FROM " + table + " ORDER BY " + field + " DESC LIMIT 1";
            this.SetCMD(query);
            this.SetReader();
            int r = 0;
            while (this.DataReader.Read())
            {
                r = Convert.ToInt32(this.DataReader[field]);
            }
            this.CloseConnection();
            return r;
        }

        public Boolean Exists(string query, string field)
        {
            bool r = false;
            this.SetCMD(query);
            this.SetReader();
            
            while (this.DataReader.Read())
            {
                if (Convert.ToString(this.DataReader[field])!="")
                    r = true;
            }
            this.CloseConnection();
            return r;
        }

       


        /***********************************************************************************
            | USUARIO
       */
        public Boolean ExistOneField(string table, string field, string value)
        {
            string query = "SELECT * FROM " + table;
            this.SetCMD(query);
            this.SetReader();
            bool r = false;
            while (this.DataReader.Read())
            {
                if (Convert.ToString(this.DataReader[field]) == value)
                    r = true;
            }
            this.CloseConnection();
            return r;
        }

        public List<Usuarios> SelectFromAll(string table)
        {
            string query = "SELECT * FROM " + table;
            this.SetCMD(query);
            this.SetReader();

            List<Usuarios> ListUsuario = new List<Usuarios>();
            Usuarios usuarios;

            while (this.DataReader.Read())
            {
                usuarios = new Usuarios();
                usuarios.IdUsuarios = Convert.ToInt32(this.DataReader["idUsuarios"]);
                usuarios.Ativo = Convert.ToInt16(this.DataReader["ativo"]);
                usuarios.Nome = Convert.ToString(this.DataReader["nomeUsuario"]);
                usuarios.Email = Convert.ToString(this.DataReader["email"]);
                usuarios.Username = Convert.ToString(this.DataReader["username"]);
                usuarios.Passwd = Convert.ToString(this.DataReader["passwd"]);
                usuarios.perfilCodPerfil = Convert.ToInt32(this.DataReader["perfil_codPerfil"]);
                ListUsuario.Add(usuarios);
            }
            this.CloseConnection();
            return ListUsuario;
        }

        public Boolean InsertUsuario(List<Usuarios> LU)
        {
            string query = "";
            Boolean r = false;
            this.hw = new Hash();
            LU.ForEach(delegate (Usuarios user) {
                query = "INSERT INTO usuarios (ativo,nomeUsuario,email,username,passwd,perfil_codPerfil) VALUES (@ativo,@nomeUsuario,@email,@username,@passwd,@cp);";
                this.SetCMD(query);
                this.CMD.Parameters.Add("@ativo", DbType.Int16).Value = user.Ativo;
                this.CMD.Parameters.Add("@nomeUsuario", DbType.String).Value = user.Nome;
                this.CMD.Parameters.Add("@email", DbType.String).Value = user.Email;
                this.CMD.Parameters.Add("@username", DbType.String).Value = user.Username;
                this.CMD.Parameters.Add("@passwd", DbType.String).Value = this.hw.SetValueHash(user.Passwd);
                this.CMD.Parameters.Add("@cp", DbType.Int32).Value = user.perfilCodPerfil;
                this.SetWriter();
                r = true;
            });
            this.CloseConnection();
            return r;
        }


        public Boolean UpdateUsuario(Usuarios usuario)
        {
            bool r = false;
            string query = "UPDATE usuarios " +
                            "SET " +
                            "ativo=@ativo," +
                            "nomeUsuario=@nomeUsuario," +
                            "email=@email," +
                            "username=@username," +
                            "perfil_codperfil=@perfil_idperfil " +
                            "where idusuarios=@idusuarios;";
            try
            {
                this.SetCMD(query);
                this.CMD.Parameters.Add("@ativo", DbType.Int16).Value = usuario.Ativo;
                this.CMD.Parameters.Add("@nomeUsuario", DbType.String).Value = usuario.Nome;
                this.CMD.Parameters.Add("@email", DbType.String).Value = usuario.Email;
                this.CMD.Parameters.Add("@username", DbType.String).Value = usuario.Username;
                this.CMD.Parameters.Add("@perfil_idperfil", DbType.Int32).Value = usuario.perfilCodPerfil;
                this.CMD.Parameters.Add("@idusuarios", DbType.String).Value = usuario.IdUsuarios;
                this.SetWriter();
                r = true;
            }
            catch (InvalidCastException e)
            {
                r = false;
            }
            this.CloseConnection();
            return r;
        }

        public Boolean ResetPasswd(int idUsuarios, string passwd)
        {
            Hash hww = new Hash();
            bool r = false;
            string query = "update usuarios set passwd=@passwd where idusuarios=@idusuarios;";
            try
            {
                this.SetCMD(query);
                this.CMD.Parameters.Add("@idusuarios", DbType.Int32).Value = idUsuarios;
                this.CMD.Parameters.Add("@passwd", DbType.String).Value = hww.SetValueHash(passwd);
                this.SetWriter();
                r = true;
            }
            catch (InvalidCastException e)
            {
                r = false;
            }
            this.CloseConnection();
            return r;
        }


        /***********************************************************************************
            | ESTADOS
        */
         public List<Estados> SelectFromAllEstados(string table)
         {
            string query = "SELECT * FROM " + table;
            this.SetCMD(query);
            this.SetReader();

            List<Estados> ListEstados = new List<Estados>();
            Estados estados;

            while (this.DataReader.Read())
            {
                estados = new Estados();
                estados.IdEstados = Convert.ToInt32(this.DataReader["idEstados"]);
                estados.CodEstado = Convert.ToInt32(this.DataReader["codEstado"]);
                estados.NomeEstado = Convert.ToString(this.DataReader["nomeEstado"]);
                estados.Uf = Convert.ToString(this.DataReader["uf"]);
                ListEstados.Add(estados);
            }
            this.CloseConnection();
            return ListEstados;
        }

        /***********************************************************************************
           | TITULACAO
       */
        public List<Titulacao> SelectFromAllTitulacao(string table)
        {
            string query = "SELECT * FROM " + table;
            this.SetCMD(query);
            this.SetReader();

            List<Titulacao> ListTitulacao = new List<Titulacao>();
            Titulacao titulacao;

            while (this.DataReader.Read())
            {
                titulacao = new Titulacao();
                titulacao.IdTitulacao = Convert.ToInt32(this.DataReader["idTitulacao"]);
                titulacao.CodTitulacao = Convert.ToInt32(this.DataReader["codTitulacao"]);
                titulacao.NomeTitulacao = Convert.ToString(this.DataReader["nomeTitulacao"]);
                ListTitulacao.Add(titulacao);
            }
            this.CloseConnection();
            return ListTitulacao;
        }


        /***********************************************************************************
           | TITULOS
       */
        public Boolean InserTitulos(List<Titulos> LT)
        {
            string query = "";
            Boolean r = false;
            LT.ForEach(delegate (Titulos titu) {
                query = "INSERT INTO titulos (nomeInstituicaoTitulo,dataTitulo,titulacao_idtitulacao,palestrante_idpalestrante) VALUES (@nomeInstituicaoTitulo,@dataTitulo,@titulacao_idtitulacao,@palestrante_idpalestrante);";
                this.SetCMD(query);
                this.CMD.Parameters.Add("@nomeInstituicaoTitulo", DbType.String).Value = titu.NomeInstituicaoTitulo;
                this.CMD.Parameters.Add("@dataTitulo", DbType.DateTime).Value = titu.dataTitulo;
                this.CMD.Parameters.Add("@titulacao_idtitulacao", DbType.Int32).Value = titu.Titulacao_idTitulacao;
                this.CMD.Parameters.Add("@palestrante_idpalestrante", DbType.Int32).Value = titu.Palestrante_idPalestrante;
                this.SetWriter();
                r = true;
            });
            this.CloseConnection();
            return r;
        }

        public Boolean UpdateTitulos(Titulos titulos)
        {
            bool r = false;
            string query = "UPDATE titulos " +
                            "SET " +
                            "nomeInstituicaoTitulo=@nomeInstituicaoTitulo," +
                            "dataTitulo=@dataTitulo," +
                            "titulacao_idtitulacao=@titulacao_idtitulacao " +
                            "where palestrante_idpalestrante=@palestrante_idpalestrante;";
            try
            {
                this.SetCMD(query);
                this.CMD.Parameters.Add("@nomeInstituicaoTitulo", DbType.String).Value = titulos.NomeInstituicaoTitulo;
                this.CMD.Parameters.Add("@dataTitulo", DbType.DateTime).Value = titulos.dataTitulo;
                this.CMD.Parameters.Add("@titulacao_idtitulacao", DbType.Int32).Value = titulos.Titulacao_idTitulacao;
                this.CMD.Parameters.Add("@palestrante_idpalestrante", DbType.Int32).Value = titulos.Palestrante_idPalestrante;
                this.SetWriter();
                r = true;
            }
            catch (InvalidCastException e)
            {
                r = false;
            }
            this.CloseConnection();
            return r;
        }

        public Boolean DeleteTitulos(int idPalestrante, int idTitulacao)
        {
            bool r = false;            
            try
            {
                string query = "DELETE FROM titulos WHERE palestrante_idpalestrante=" + idPalestrante+" and titulacao_idtitulacao="+idTitulacao;
                this.SetCMD(query);
                this.SetWriter();
                r = true;
            }
            catch (InvalidCastException e)
            {
                r = false;
            }
            this.CloseConnection();
            return r;
        }



        /***********************************************************************************
          | PALETRANTE
       */
        public Boolean InsertPalestrante(List<Palestrante> LP)
        {
            string query = "";
            Boolean r = false;
            LP.ForEach(delegate (Palestrante pale) {
                query = "INSERT INTO palestrante (codPalestrante,nomePalestrante) VALUES (@codPalestrante,@nomePalestrante);";
                this.SetCMD(query);
                this.CMD.Parameters.Add("@codPalestrante", DbType.Int32).Value = pale.CodPalestrante;
                this.CMD.Parameters.Add("@nomePalestrante", DbType.String).Value = pale.NomePalestrante;
                this.SetWriter();
                r = true;
            });
            this.CloseConnection();
            return r;
        }

        public List<Palestrante> SelectFromAllPalestrante()
        {
            string query = "SELECT * FROM palestrante";
            this.SetCMD(query);
            this.SetReader();

            List<Palestrante> ListPalestrante = new List<Palestrante>();
            Palestrante palestrante;

            while (this.DataReader.Read())
            {
                palestrante = new Palestrante();
                palestrante.IdPalestrante = Convert.ToInt32(this.DataReader["idpalestrante"]);
                palestrante.CodPalestrante = Convert.ToInt32(this.DataReader["codPalestrante"]);
                palestrante.NomePalestrante = Convert.ToString(this.DataReader["nomePalestrante"]);
                ListPalestrante.Add(palestrante);
            }
            this.CloseConnection();
            return ListPalestrante;
        }

        public Boolean UpdatePalestrante(Interface_has_Palestrante_InfoPalestrante_Titulos_Estados pite)
        {
            bool r = false;
            string query = "UPDATE palestrante " +
                            "SET " +
                            "nomePalestrante=@nomePalestrante " +
                            "where idpalestrante=@idPalestrante;";
            try
            {
                this.SetCMD(query);
                this.CMD.Parameters.Add("@nomePalestrante", DbType.String).Value = pite.Palestrante.NomePalestrante;
                this.CMD.Parameters.Add("@idPalestrante", DbType.String).Value = pite.Palestrante.IdPalestrante;
                this.SetWriter();
                r = true;
            }
            catch (InvalidCastException e)
            {
                r = false;
            }
            this.CloseConnection();
            return r;
        }

        public Int32 SelectOneIDPalestrante(string field, string nomePalestrante)
        {                           
            string query = "SELECT " + field + " from palestrante where nomePalestrante='"+nomePalestrante+"';";
            this.SetCMD(query);
            this.SetReader();
            int r = 0;
            while (this.DataReader.Read())
            {
                r = Convert.ToInt32(this.DataReader[field]);
            }                        
            this.CloseConnection();
            return r;
        }

        /***********************************************************************************
        | INFOPALETRANTE
        */
        public Boolean InsertInfoPalestrante(List<InfoPalestrante> LIP)
        {
            string query = "";
            Boolean r = false;
            LIP.ForEach(delegate (InfoPalestrante infopale) {
                query = "INSERT INTO infopalestrante (telefoneFixo,celular,email,cidade,palestrante_idpalestrante,estados_idestados) VALUES (@telefoneFixo,@celular,@email,@cidade,@palestrante_idpalestrante,@estados_idestados);";
                this.SetCMD(query);
                this.CMD.Parameters.Add("@telefoneFixo", DbType.String).Value = infopale.TelefoneFixo;
                this.CMD.Parameters.Add("@celular", DbType.String).Value = infopale.Celular;
                this.CMD.Parameters.Add("@email", DbType.String).Value = infopale.Email;
                this.CMD.Parameters.Add("@cidade", DbType.String).Value = infopale.Cidade;
                this.CMD.Parameters.Add("@palestrante_idpalestrante", DbType.Int32).Value = infopale.Palestrante_idPalestrante;
                this.CMD.Parameters.Add("@estados_idestados", DbType.Int32).Value = infopale.Estados_idEstados;
                this.SetWriter();
                r = true;
            });
            this.CloseConnection();
            return r;
        }

        public Boolean UpdateInfoPalestrante(Interface_has_Palestrante_InfoPalestrante_Titulos_Estados pite)
        {
            bool r = false;
            string query = "UPDATE infopalestrante " +
                            "SET " +
                            "telefoneFixo=@telefoneFixo," +
                            "celular=@celular," +
                            "email=@email," +
                            "cidade=@cidade," +
                            "estados_idestados=@estados_idestados " +
                            "where palestrante_idpalestrante=@palestrante_idpalestrante";
            try
            {
                this.SetCMD(query);
                this.CMD.Parameters.Add("@telefoneFixo", DbType.String).Value = pite.InfoPalestrante.TelefoneFixo;
                this.CMD.Parameters.Add("@celular", DbType.String).Value = pite.InfoPalestrante.Celular;
                this.CMD.Parameters.Add("@email", DbType.String).Value = pite.InfoPalestrante.Email;
                this.CMD.Parameters.Add("@cidade", DbType.String).Value = pite.InfoPalestrante.Cidade;
                this.CMD.Parameters.Add("@estados_idestados", DbType.Int32).Value = pite.InfoPalestrante.Estados_idEstados;
                this.CMD.Parameters.Add("@palestrante_idpalestrante", DbType.Int32).Value = pite.Palestrante.IdPalestrante;
                this.SetWriter();
                r = true;
            }
            catch (InvalidCastException e)
            {
                r = false;
            }
            this.CloseConnection();
            return r;
        }


        /***********************************************************************************
        | PERFIL
        */
        public List<Perfil> SelectFromAllPerfil()
        {
            string query = "SELECT * FROM perfil";
            this.SetCMD(query);
            this.SetReader();

            List<Perfil> ListPerfil = new List<Perfil>();
            Perfil perfil;

            while (this.DataReader.Read())
            {
                perfil = new Perfil();
                perfil.IdPerfil = Convert.ToInt32(this.DataReader["idperfil"]);
                perfil.CodPerfil = Convert.ToInt32(this.DataReader["codPerfil"]);
                perfil.NomePerfil = Convert.ToString(this.DataReader["nomePerfil"]);
                ListPerfil.Add(perfil);
            }
            this.CloseConnection();
            return ListPerfil;
        }


        /***********************************************************************************
        | EVENTOS
        */
        public Boolean InsertEventos(Eventos eventos)
        {
            string query = "";
            Boolean r = false;
                query = "INSERT INTO evento (tituloEvento,dataEvento,horarioInicial,horarioFinal,usuarios_idUsuarios,palestrante_idPalestrante) VALUES (@tituloEvento,@dataEvento,@horarioInicial,@horarioFinal,@usuarios_idUsuarios,@palestrante_idPalestrante);";
                this.SetCMD(query);
                this.CMD.Parameters.Add("@tituloEvento", DbType.String).Value = eventos.TituloEvento;
                this.CMD.Parameters.Add("@dataEvento", DbType.DateTime).Value = eventos.DataEvento;
                this.CMD.Parameters.Add("@horarioInicial", DbType.DateTime).Value = eventos.HInicio;
                this.CMD.Parameters.Add("@horarioFinal", DbType.DateTime).Value = eventos.HFim;
                this.CMD.Parameters.Add("@palestrante_idPalestrante", DbType.Int32).Value = eventos.Palestrante_idPalestrante;
                this.CMD.Parameters.Add("@usuarios_idUsuarios", DbType.Int32).Value = eventos.Usuarios_IdUsuarios;
                this.SetWriter();
                r = true;            
            this.CloseConnection();
            return r;
        }

        public Boolean UpdateEventos(Eventos eventos)
        {
            bool r = false;
            string query = "UPDATE evento " +
                            "SET " +
                            "tituloEvento=@tituloEvento,"+
                            "dataEvento=@dataEvento,"+
                            "horarioInicial=@horarioInicial," +
                            "horarioFinal=@horarioFinal," +
                            "palestrante_idpalestrante=@palestrante_idpalestrante "+
                            "where usuarios_idUsuarios=@usuarios_idUsuarios and idEvento=@idEvento;";
            try
            {
                this.SetCMD(query);
                this.CMD.Parameters.Add("@tituloEvento", DbType.String).Value = eventos.TituloEvento;
                this.CMD.Parameters.Add("@dataEvento", DbType.DateTime).Value = eventos.DataEvento;
                this.CMD.Parameters.Add("@horarioInicial", DbType.String).Value = eventos.HInicio;
                this.CMD.Parameters.Add("@horarioFinal", DbType.String).Value = eventos.HFim;
                this.CMD.Parameters.Add("@palestrante_idpalestrante", DbType.Int32).Value = eventos.Palestrante_idPalestrante;
                this.CMD.Parameters.Add("@usuarios_idUsuarios", DbType.Int32).Value = eventos.Usuarios_IdUsuarios;
                this.CMD.Parameters.Add("@idEvento", DbType.Int32).Value = eventos.IdEvento;
                this.SetWriter();
                r = true;
            }
            catch (InvalidCastException e)
            {
                r = false;
            }
            this.CloseConnection();
            return r;
        }

        public String SelectOneOneEventos(string field, int idEvento)
        {
            string query = "SELECT " + field + " from evento where idEvento=" + idEvento + ";";
            this.SetCMD(query);
            this.SetReader();
            string r = "";
            while (this.DataReader.Read())
            {
                r = Convert.ToString(this.DataReader[field]);
            }
            this.CloseConnection();
            return r;
        }


        /***********************************************************************************
         | CURSO
        */
        public Int32 SelectOneIDCurso(string field, string nomeCurso)
        {
            string query = "SELECT " + field + " from curso where nomeCurso='" + nomeCurso + "';";
            this.SetCMD(query);
            this.SetReader();
            int r = 0;
            while (this.DataReader.Read())
            {
                r = Convert.ToInt32(this.DataReader[field]);
            }
            this.CloseConnection();
            return r;
        }

        public String SelectOneNameCurso(string field, int idCurso)
        {
            string query = "SELECT " + field + " from curso where idCurso=" + idCurso + ";";
            this.SetCMD(query);
            this.SetReader();
            string r = "";
            while (this.DataReader.Read())
            {
                r = Convert.ToString(this.DataReader[field]);
            }
            this.CloseConnection();
            return r;
        }

        public List<Curso> SelectFromAllCurso()
        {
            string query = "SELECT * FROM curso";
            this.SetCMD(query);
            this.SetReader();

            List<Curso> ListCurso = new List<Curso>();
            Curso curso;

            while (this.DataReader.Read())
            {
                curso = new Curso();
                curso.IdCurso = Convert.ToInt32(this.DataReader["idCurso"]);
                curso.CodCurso = Convert.ToInt32(this.DataReader["CodCurso"]);
                curso.NomeCurso = Convert.ToString(this.DataReader["nomeCurso"]);
                ListCurso.Add(curso);
            }
            this.CloseConnection();
            return ListCurso;
        }




        /***********************************************************************************
        | PERÍODO
       */
        public List<Periodo> SelectFromAllPeriodo()
        {
            string query = "SELECT * FROM periodo";
            this.SetCMD(query);
            this.SetReader();

            List<Periodo> ListPeriodo = new List<Periodo>();
            Periodo periodo;

            while (this.DataReader.Read())
            {
                periodo = new Periodo();
                periodo.IdPeriodo = Convert.ToInt32(this.DataReader["idperiodo"]);
                periodo.CodPeriodo = Convert.ToInt32(this.DataReader["codperiodo"]);
                periodo.NomePeriodo = Convert.ToString(this.DataReader["nomeperiodo"]);
                ListPeriodo.Add(periodo);
            }
            this.CloseConnection();
            return ListPeriodo;
        }

        public Int32 SelectOneIDPeriodo(string field, string nomePeriodo)
        {
            string query = "SELECT " + field + " from periodo where nomeperiodo='" + nomePeriodo + "';";
            this.SetCMD(query);
            this.SetReader();
            int r = 0;
            while (this.DataReader.Read())
            {
                r = Convert.ToInt32(this.DataReader[field]);
            }
            this.CloseConnection();
            return r;
        }

        public String SelectOneNamePeriodo(string field, int idPeriodo)
        {
            string query = "SELECT " + field + " from periodo where idPeriodo=" + idPeriodo + ";";
            this.SetCMD(query);
            this.SetReader();
            string r = "";
            while (this.DataReader.Read())
            {
                r = Convert.ToString(this.DataReader[field]);
            }
            this.CloseConnection();
            return r;
        }

        /***********************************************************************************
        | INFOUSER
       */
        public Boolean InsertInfoUser(InfoUser infouser)
        {
            string query = "";
            Boolean r = false;
            query = "INSERT INTO infouser (cpf,usuarios_idUsuarios,periodo_idperiodo,curso_idcurso) VALUES (@cpf,@usuarios_idUsuarios,@periodo_idperiodo,@curso_idcurso);";
            this.SetCMD(query);
            this.CMD.Parameters.Add("@cpf", DbType.String).Value = infouser.CPF;
            this.CMD.Parameters.Add("@usuarios_idusuarios", DbType.Int32).Value = infouser.Usuario_IdUsuario;
            this.CMD.Parameters.Add("@periodo_idperiodo", DbType.Int32).Value = infouser.Periodo_IdPeriodo;
            this.CMD.Parameters.Add("@curso_idcurso", DbType.Int32).Value = infouser.Curso_IdCurso;
            this.SetWriter();
            r = true;
            this.CloseConnection();
            return r;
        }

        public InfoUser SelectFromOneInfoUser(int idUsuario)
        {
            string query = "SELECT * FROM infouser where usuarios_idusuarios="+idUsuario;
            this.SetCMD(query);
            this.SetReader();

            InfoUser infouser = new InfoUser();

            while (this.DataReader.Read())            {
               
                infouser.IdInfoUser = Convert.ToInt32(this.DataReader["idInfoUser"]);
                infouser.CPF = Convert.ToString(this.DataReader["cpf"]);
                infouser.Usuario_IdUsuario = Convert.ToInt32(this.DataReader["usuarios_idusuarios"]);
                infouser.Periodo_IdPeriodo = Convert.ToInt32(this.DataReader["periodo_idperiodo"]);
                infouser.Curso_IdCurso = Convert.ToInt32(this.DataReader["curso_idcurso"]);
            }
            this.CloseConnection();
            return infouser;
        }

        public Boolean UpdateInfoUser(InfoUser infouser)
        {
            bool r = false;
            string query = "UPDATE infouser " +
                            "SET " +
                            "cpf=@cpf," +
                            "periodo_idperiodo=@periodo_idperiodo," +
                            "curso_idcurso=@curso_idcurso " +
                            "where usuarios_idusuarios=@usuarios_idusuarios;";
            try
            {
                this.SetCMD(query);
                this.CMD.Parameters.Add("@cpf", DbType.String).Value = infouser.CPF;
                this.CMD.Parameters.Add("@periodo_idperiodo", DbType.Int32).Value = infouser.Periodo_IdPeriodo;
                this.CMD.Parameters.Add("@curso_idcurso", DbType.Int32).Value = infouser.Curso_IdCurso;
                this.CMD.Parameters.Add("@usuarios_idusuarios", DbType.Int32).Value = infouser.Usuario_IdUsuario;
                this.SetWriter();
                r = true;
            }
            catch (InvalidCastException e)
            {
                r = false;
            }
            this.CloseConnection();
            return r;
        }


        /***********************************************************************************
         | CURSO
        */
        public Boolean InsertInscricao(Inscricao inscricao)
        {
            string query = "";
            Boolean r = false;
            query = "INSERT INTO inscricao (matricula,usuarios_idusuarios,evento_idevento) VALUES (@matricula,@usuarios_idusuarios,@evento_idevento);";
            this.SetCMD(query);
            this.CMD.Parameters.Add("@matricula", DbType.String).Value = inscricao.Matricula;
            this.CMD.Parameters.Add("@usuarios_idusuarios", DbType.Int32).Value = inscricao.Usuarios_IdUsuarios;
            this.CMD.Parameters.Add("@evento_idevento", DbType.Int32).Value = inscricao.Evento_IdEvento;
            this.SetWriter();
            r = true;
            this.CloseConnection();
            return r;
        }
    }
}
