// observer pattern 
namespace DesignPatterns.observer{
    interface Observer {
  public function update($message_description);
}

interface Observable {
  public function attach(Observer $observer);
  public function detach(Observer $observer);
  public function notify($message_description);
}

class Notification implements Observable {
  private $observers = [];

  public function attach(Observer $observer) {
    $this->observers[] = $observer;
  }

  public function detach(Observer $observer) {
    $index = array_search($observer, $this->observers);
    if ($index !== false) {
      unset($this->observers[$index]);
    }
  }

  public function notify($message_description) {
    foreach ($this->observers as $observer) {
      $observer->update($message);
    }
  }

  // Other methods for managing notifications
}

class User implements Observer {
  private $user_name;

  public function __construct($user_name) {
    $this->user_name = $user_name;
  }

  public function update($message_description) {
    echo "$this->name received notification: $message_desciption\n";
  }

  // Other methods for managing user accounts
}
}