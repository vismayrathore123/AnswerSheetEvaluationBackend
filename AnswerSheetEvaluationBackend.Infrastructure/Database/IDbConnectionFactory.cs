using Npgsql;

namespace AnswerSheetEvaluation.Data
{
    public interface IDbConnectionFactory
    {
        NpgsqlConnection CreateConnection();
    }
}
