//proxy pattern
namespace DesignPatterns.StructuralPatterns{
    interface GroupInterface {
  public function addMember($member_id);
  public function getMembers();
}

class Group implements GroupInterface {
  private $members = [];

  public function addMember($member_id) {
    $this->members[] = $member_id;
    echo "Added $member to group.\n";
  }

  public function getMembers() {
    return $this->members;
  }
}

class GroupProxy implements GroupInterface {
  private $group;

  public function addMember($member_id) {
    if (!$this->group) {
      $this->group = new Group();
    }
    $this->group->addMember($member_id);
  }

  public function getMembers() {
    if (!$this->group) {
      $this->group = new Group();
    }
    return $this->group->getMembers();
  }
}
}