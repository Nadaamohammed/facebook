//immutable pattern
namespace DesignPatterns.Immutable{
    class Database {
  private $host;
  private $username;
  private $password;
  private $databaseName;

  public function __construct($host, $username, $password, $databaseName) {
    $this->host = $host;
    $this->username = $username;
    $this->password = $password;
    $this->databaseName = $databaseName;
  }

  public function connect() {
    $connection = mysqli_connect($this->host, $this->username, $this->password, $this->databaseName);

    if (!$connection) {
      die('Connection failed: ' . mysqli_connect_error());
    }

    return $connection;
  }
}
}