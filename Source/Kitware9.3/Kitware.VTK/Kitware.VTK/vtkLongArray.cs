using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLongArray
	/// </summary>
	/// <remarks>
	///    dynamic, self-adjusting array of long
	///
	/// vtkLongArray is an array of values of type long.  It provides
	/// methods for insertion and retrieval of values and will
	/// automatically resize itself to hold new data.
	///
	/// The C++ standard does not define the exact size of the long type, so use
	/// of this type directly is discouraged.  If an array of 32 bit integers is
	/// needed, prefer vtkTypeInt32Array to this class.  If an array of 64 bit
	/// integers is needed, prefer vtkTypeInt64Array to this class.
	/// </remarks>
	// Token: 0x02000B6C RID: 2924
	public class vtkLongArray : vtkDataArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E872 RID: 125042 RVA: 0x002B5066 File Offset: 0x002B3266
		static vtkLongArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLongArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLongArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E873 RID: 125043 RVA: 0x002B508E File Offset: 0x002B328E
		public vtkLongArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E874 RID: 125044
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLongArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E875 RID: 125045 RVA: 0x002B509C File Offset: 0x002B329C
		public new static vtkLongArray New()
		{
			vtkLongArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLongArray.vtkLongArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E876 RID: 125046 RVA: 0x002B50F0 File Offset: 0x002B32F0
		public vtkLongArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLongArray.vtkLongArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E877 RID: 125047 RVA: 0x002B5134 File Offset: 0x002B3334
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E878 RID: 125048
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLongArray_ExtendedNew_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E879 RID: 125049 RVA: 0x002B5140 File Offset: 0x002B3340
		public static vtkLongArray ExtendedNew()
		{
			vtkLongArray vtkLongArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLongArray.vtkLongArray_ExtendedNew_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLongArray = (vtkLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLongArray.Register(null);
				}
			}
			return vtkLongArray;
		}

		// Token: 0x0601E87A RID: 125050
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLongArray_FastDownCast_02(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A faster alternative to SafeDownCast for downcasting vtkAbstractArrays.
		/// </summary>
		// Token: 0x0601E87B RID: 125051 RVA: 0x002B51AC File Offset: 0x002B33AC
		public new static vtkLongArray FastDownCast(vtkAbstractArray source)
		{
			vtkLongArray vtkLongArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLongArray.vtkLongArray_FastDownCast_02((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLongArray = (vtkLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLongArray.Register(null);
				}
			}
			return vtkLongArray;
		}

		// Token: 0x0601E87C RID: 125052
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLongArray_GetDataTypeValueMax_03();

		/// <summary>
		/// Get the maximum data value in its native type.
		/// </summary>
		// Token: 0x0601E87D RID: 125053 RVA: 0x002B522C File Offset: 0x002B342C
		public static int GetDataTypeValueMax()
		{
			return vtkLongArray.vtkLongArray_GetDataTypeValueMax_03();
		}

		// Token: 0x0601E87E RID: 125054
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLongArray_GetDataTypeValueMin_04();

		/// <summary>
		/// Get the minimum data value in its native type.
		/// </summary>
		// Token: 0x0601E87F RID: 125055 RVA: 0x002B5248 File Offset: 0x002B3448
		public static int GetDataTypeValueMin()
		{
			return vtkLongArray.vtkLongArray_GetDataTypeValueMin_04();
		}

		// Token: 0x0601E880 RID: 125056
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLongArray_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E881 RID: 125057 RVA: 0x002B5264 File Offset: 0x002B3464
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLongArray.vtkLongArray_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E882 RID: 125058
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLongArray_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E883 RID: 125059 RVA: 0x002B5284 File Offset: 0x002B3484
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLongArray.vtkLongArray_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601E884 RID: 125060
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLongArray_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E885 RID: 125061 RVA: 0x002B52A0 File Offset: 0x002B34A0
		public override int IsA(string type)
		{
			return vtkLongArray.vtkLongArray_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E886 RID: 125062
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLongArray_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E887 RID: 125063 RVA: 0x002B52C0 File Offset: 0x002B34C0
		public new static int IsTypeOf(string type)
		{
			return vtkLongArray.vtkLongArray_IsTypeOf_08(type);
		}

		// Token: 0x0601E888 RID: 125064
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLongArray_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E889 RID: 125065 RVA: 0x002B52DC File Offset: 0x002B34DC
		public new vtkLongArray NewInstance()
		{
			vtkLongArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLongArray.vtkLongArray_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E88A RID: 125066
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLongArray_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E88B RID: 125067 RVA: 0x002B5338 File Offset: 0x002B3538
		public new static vtkLongArray SafeDownCast(vtkObjectBase o)
		{
			vtkLongArray vtkLongArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLongArray.vtkLongArray_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLongArray = (vtkLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLongArray.Register(null);
				}
			}
			return vtkLongArray;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020B7 RID: 8375
		public new const string MRFullTypeName = "Kitware.VTK.vtkLongArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020B8 RID: 8376
		public new static readonly string MRClassNameKey = "class vtkLongArray";
	}
}
