// delegatio pattern
namespace DesignPatterns.StructuralPatterns
{
    interface SocialMediaGroup {
  public function getMembers();
}

class SocialMediaGroupImpl implements SocialMediaGroup {
  private $members;

  public function __construct() {
    // Load members list from the database or API
    $this->members = ['Alice', 'Bob', 'Charlie'];
  }

  public function getMembers() {
    return $this->members;
  }
}

class Group implements SocialMediaGroup {
  private $socialMediaGroup;

  public function __construct() {
    $this->socialMediaGroup = new SocialMediaGroupImpl();
  }

  public function getMembers() {
    return $this->socialMediaGroup->getMembers();
  }
}
}