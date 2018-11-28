﻿using System.Runtime.Serialization;

namespace Nest
{
	public enum UserAgentProperty
	{
		[EnumMember(Value = "NAME")] Name,
		[EnumMember(Value = "MAJOR")] Major,
		[EnumMember(Value = "MINOR")] Minor,
		[EnumMember(Value = "PATCH")] Patch,
		[EnumMember(Value = "OS")] Os,
		[EnumMember(Value = "OS_NAME")] OsName,
		[EnumMember(Value = "OS_MAJOR")] OsMajor,
		[EnumMember(Value = "OS_MINOR")] OsMinor,
		[EnumMember(Value = "DEVICE")] Device,
		[EnumMember(Value = "BUILD")] Build
	}
}
