using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTimePointUtility
	/// </summary>
	/// <remarks>
	///    performs common time operations
	///
	///
	/// vtkTimePointUtility is provides methods to perform common time operations.
	/// </remarks>
	// Token: 0x02000B81 RID: 2945
	public class vtkTimePointUtility : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601EBAE RID: 125870 RVA: 0x002B94C3 File Offset: 0x002B76C3
		static vtkTimePointUtility()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTimePointUtility.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTimePointUtility"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601EBAF RID: 125871 RVA: 0x002B94EB File Offset: 0x002B76EB
		public vtkTimePointUtility(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601EBB0 RID: 125872
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTimePointUtility_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBB1 RID: 125873 RVA: 0x002B94FC File Offset: 0x002B76FC
		public new static vtkTimePointUtility New()
		{
			vtkTimePointUtility result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTimePointUtility.vtkTimePointUtility_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTimePointUtility)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBB2 RID: 125874 RVA: 0x002B9550 File Offset: 0x002B7750
		public vtkTimePointUtility() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTimePointUtility.vtkTimePointUtility_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601EBB3 RID: 125875 RVA: 0x002B9594 File Offset: 0x002B7794
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601EBB4 RID: 125876
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTimePointUtility_DateTimeToTimePoint_01(int year, int month, int day, int hour, int minute, int sec, int millis);

		/// <summary>
		/// Return the time point for a date and time.
		/// </summary>
		// Token: 0x0601EBB5 RID: 125877 RVA: 0x002B95A0 File Offset: 0x002B77A0
		public static ulong DateTimeToTimePoint(int year, int month, int day, int hour, int minute, int sec, int millis)
		{
			return vtkTimePointUtility.vtkTimePointUtility_DateTimeToTimePoint_01(year, month, day, hour, minute, sec, millis);
		}

		// Token: 0x0601EBB6 RID: 125878
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTimePointUtility_DateToTimePoint_02(int year, int month, int day);

		/// <summary>
		/// Return the time point for 12:00am on a specified day.
		/// </summary>
		// Token: 0x0601EBB7 RID: 125879 RVA: 0x002B95C4 File Offset: 0x002B77C4
		public static ulong DateToTimePoint(int year, int month, int day)
		{
			return vtkTimePointUtility.vtkTimePointUtility_DateToTimePoint_02(year, month, day);
		}

		// Token: 0x0601EBB8 RID: 125880
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimePointUtility_GetDate_03(ulong time, ref int year, ref int month, ref int day);

		/// <summary>
		/// Retrieve the year, month, and day of a time point.
		/// Everything but the first argument are output parameters.
		/// </summary>
		// Token: 0x0601EBB9 RID: 125881 RVA: 0x002B95E0 File Offset: 0x002B77E0
		public static void GetDate(ulong time, ref int year, ref int month, ref int day)
		{
			vtkTimePointUtility.vtkTimePointUtility_GetDate_03(time, ref year, ref month, ref day);
		}

		// Token: 0x0601EBBA RID: 125882
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimePointUtility_GetDateTime_04(ulong time, ref int year, ref int month, ref int day, ref int hour, ref int minute, ref int second, ref int millis);

		/// <summary>
		/// Retrieve the date and time of a time point.
		/// Everything but the first argument are output parameters.
		/// </summary>
		// Token: 0x0601EBBB RID: 125883 RVA: 0x002B95ED File Offset: 0x002B77ED
		public static void GetDateTime(ulong time, ref int year, ref int month, ref int day, ref int hour, ref int minute, ref int second, ref int millis)
		{
			vtkTimePointUtility.vtkTimePointUtility_GetDateTime_04(time, ref year, ref month, ref day, ref hour, ref minute, ref second, ref millis);
		}

		// Token: 0x0601EBBC RID: 125884
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimePointUtility_GetDay_05(ulong time);

		/// <summary>
		/// Retrieve the day of the month from a time point.
		/// </summary>
		// Token: 0x0601EBBD RID: 125885 RVA: 0x002B9604 File Offset: 0x002B7804
		public static int GetDay(ulong time)
		{
			return vtkTimePointUtility.vtkTimePointUtility_GetDay_05(time);
		}

		// Token: 0x0601EBBE RID: 125886
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimePointUtility_GetHour_06(ulong time);

		/// <summary>
		/// Retrieve the hour of the day from the time point.
		/// </summary>
		// Token: 0x0601EBBF RID: 125887 RVA: 0x002B9620 File Offset: 0x002B7820
		public static int GetHour(ulong time)
		{
			return vtkTimePointUtility.vtkTimePointUtility_GetHour_06(time);
		}

		// Token: 0x0601EBC0 RID: 125888
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimePointUtility_GetMillisecond_07(ulong time);

		/// <summary>
		/// Retrieve the milliseconds from the start of the last second.
		/// </summary>
		// Token: 0x0601EBC1 RID: 125889 RVA: 0x002B963C File Offset: 0x002B783C
		public static int GetMillisecond(ulong time)
		{
			return vtkTimePointUtility.vtkTimePointUtility_GetMillisecond_07(time);
		}

		// Token: 0x0601EBC2 RID: 125890
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimePointUtility_GetMinute_08(ulong time);

		/// <summary>
		/// Retrieve the number of minutes from the start of the last hour.
		/// </summary>
		// Token: 0x0601EBC3 RID: 125891 RVA: 0x002B9658 File Offset: 0x002B7858
		public static int GetMinute(ulong time)
		{
			return vtkTimePointUtility.vtkTimePointUtility_GetMinute_08(time);
		}

		// Token: 0x0601EBC4 RID: 125892
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimePointUtility_GetMonth_09(ulong time);

		/// <summary>
		/// Retrieve the month from a time point.
		/// </summary>
		// Token: 0x0601EBC5 RID: 125893 RVA: 0x002B9674 File Offset: 0x002B7874
		public static int GetMonth(ulong time)
		{
			return vtkTimePointUtility.vtkTimePointUtility_GetMonth_09(time);
		}

		// Token: 0x0601EBC6 RID: 125894
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTimePointUtility_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBC7 RID: 125895 RVA: 0x002B9690 File Offset: 0x002B7890
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTimePointUtility.vtkTimePointUtility_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0601EBC8 RID: 125896
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTimePointUtility_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBC9 RID: 125897 RVA: 0x002B96B0 File Offset: 0x002B78B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTimePointUtility.vtkTimePointUtility_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0601EBCA RID: 125898
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimePointUtility_GetSecond_12(ulong time);

		/// <summary>
		/// Retrieve the number of seconds from the start of the last minute.
		/// </summary>
		// Token: 0x0601EBCB RID: 125899 RVA: 0x002B96CC File Offset: 0x002B78CC
		public static int GetSecond(ulong time)
		{
			return vtkTimePointUtility.vtkTimePointUtility_GetSecond_12(time);
		}

		// Token: 0x0601EBCC RID: 125900
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimePointUtility_GetTime_13(ulong time, ref int hour, ref int minute, ref int second, ref int millis);

		/// <summary>
		/// Retrieve the hour, minute, second, and milliseconds of a time point.
		/// Everything but the first argument are output parameters.
		/// </summary>
		// Token: 0x0601EBCD RID: 125901 RVA: 0x002B96E6 File Offset: 0x002B78E6
		public static void GetTime(ulong time, ref int hour, ref int minute, ref int second, ref int millis)
		{
			vtkTimePointUtility.vtkTimePointUtility_GetTime_13(time, ref hour, ref minute, ref second, ref millis);
		}

		// Token: 0x0601EBCE RID: 125902
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimePointUtility_GetYear_14(ulong time);

		/// <summary>
		/// Retrieve the year from a time point.
		/// </summary>
		// Token: 0x0601EBCF RID: 125903 RVA: 0x002B96F8 File Offset: 0x002B78F8
		public static int GetYear(ulong time)
		{
			return vtkTimePointUtility.vtkTimePointUtility_GetYear_14(time);
		}

		// Token: 0x0601EBD0 RID: 125904
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTimePointUtility_ISO8601ToTimePoint_15([MarshalAs(UnmanagedType.LPUTF8Str)] string str, IntPtr ok);

		/// <summary>
		/// Converts a ISO8601 string into a VTK timepoint.
		/// The string must follow one of the ISO8601 formats described
		/// in ToISO8601.  To check for a valid format, pass a bool* as
		/// the second argument.  The value will be set to true if the
		/// string was parsed successfully, false otherwise.
		/// </summary>
		// Token: 0x0601EBD1 RID: 125905 RVA: 0x002B9714 File Offset: 0x002B7914
		public static ulong ISO8601ToTimePoint(string str, IntPtr ok)
		{
			return vtkTimePointUtility.vtkTimePointUtility_ISO8601ToTimePoint_15(str, ok);
		}

		// Token: 0x0601EBD2 RID: 125906
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimePointUtility_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBD3 RID: 125907 RVA: 0x002B9730 File Offset: 0x002B7930
		public override int IsA(string type)
		{
			return vtkTimePointUtility.vtkTimePointUtility_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0601EBD4 RID: 125908
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimePointUtility_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBD5 RID: 125909 RVA: 0x002B9750 File Offset: 0x002B7950
		public new static int IsTypeOf(string type)
		{
			return vtkTimePointUtility.vtkTimePointUtility_IsTypeOf_17(type);
		}

		// Token: 0x0601EBD6 RID: 125910
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTimePointUtility_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBD7 RID: 125911 RVA: 0x002B976C File Offset: 0x002B796C
		public new vtkTimePointUtility NewInstance()
		{
			vtkTimePointUtility result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTimePointUtility.vtkTimePointUtility_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTimePointUtility)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601EBD8 RID: 125912
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTimePointUtility_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBD9 RID: 125913 RVA: 0x002B97C8 File Offset: 0x002B79C8
		public new static vtkTimePointUtility SafeDownCast(vtkObjectBase o)
		{
			vtkTimePointUtility vtkTimePointUtility = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTimePointUtility.vtkTimePointUtility_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTimePointUtility = (vtkTimePointUtility)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTimePointUtility.Register(null);
				}
			}
			return vtkTimePointUtility;
		}

		// Token: 0x0601EBDA RID: 125914
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTimePointUtility_TimePointToISO8601_21(ulong arg0, int format);

		/// <summary>
		/// Converts a VTK timepoint into one of the following ISO8601
		/// formats.  The default format is ISO8601_DATETIME_MILLIS.
		///
		/// &lt;PRE&gt;
		/// Type                      Format / Example
		/// 0 ISO8601_DATETIME_MILLIS [YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[SSS]
		/// 2006-01-02T03:04:05.678
		/// 1 ISO8601_DATETIME        [YYYY]-[MM]-[DD]T[hh]:[mm]:[ss]
		/// 2006-01-02T03:04:05
		/// 2 ISO8601_DATE            [YYYY]-[MM]-[DD]
		/// 2006-01-02
		/// 3 ISO8601_TIME_MILLIS     [hh]:[mm]:[ss].[SSS]
		/// 03:04:05.678
		/// 4 ISO8601_TIME            [hh]:[mm]:[ss]
		/// 03:04:05
		/// &lt;/PRE&gt;
		/// </summary>
		// Token: 0x0601EBDB RID: 125915 RVA: 0x002B9848 File Offset: 0x002B7A48
		public static string TimePointToISO8601(ulong arg0, int format)
		{
			string s = Marshal.PtrToStringAnsi(vtkTimePointUtility.vtkTimePointUtility_TimePointToISO8601_21(arg0, format));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601EBDC RID: 125916
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTimePointUtility_TimeToTimePoint_22(int hour, int minute, int second, int millis);

		/// <summary>
		/// Return the time point for a time of day (the number of milliseconds from 12:00am.
		/// The hour should be from 0-23.
		/// </summary>
		// Token: 0x0601EBDD RID: 125917 RVA: 0x002B9880 File Offset: 0x002B7A80
		public static ulong TimeToTimePoint(int hour, int minute, int second, int millis)
		{
			return vtkTimePointUtility.vtkTimePointUtility_TimeToTimePoint_22(hour, minute, second, millis);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020E9 RID: 8425
		public new const string MRFullTypeName = "Kitware.VTK.vtkTimePointUtility";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020EA RID: 8426
		public new static readonly string MRClassNameKey = "class vtkTimePointUtility";

		/// <summary>
		/// Retrieve the milliseconds from the start of the last second.
		/// </summary>
		// Token: 0x02000B82 RID: 2946
		public enum ISO8601_DATE_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040020EC RID: 8428
			ISO8601_DATE = 2,
			/// <summary>enum member</summary>
			// Token: 0x040020ED RID: 8429
			ISO8601_DATETIME = 1,
			/// <summary>enum member</summary>
			// Token: 0x040020EE RID: 8430
			ISO8601_DATETIME_MILLIS = 0,
			/// <summary>enum member</summary>
			// Token: 0x040020EF RID: 8431
			ISO8601_TIME = 4,
			/// <summary>enum member</summary>
			// Token: 0x040020F0 RID: 8432
			ISO8601_TIME_MILLIS = 3
		}
	}
}
