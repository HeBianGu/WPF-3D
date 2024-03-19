using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkIntArray
	/// </summary>
	/// <remarks>
	///    dynamic, self-adjusting array of int
	///
	/// vtkIntArray is an array of values of type int.  It provides
	/// methods for insertion and retrieval of values and will
	/// automatically resize itself to hold new data.
	///
	/// The C++ standard does not define the exact size of the int type, so use
	/// of this type directly is discouraged.  If an array of 32 bit integers is
	/// needed, prefer vtkTypeInt32Array to this class.
	/// </remarks>
	// Token: 0x02000B2D RID: 2861
	public class vtkIntArray : vtkDataArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E024 RID: 122916 RVA: 0x002A631B File Offset: 0x002A451B
		static vtkIntArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIntArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIntArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E025 RID: 122917 RVA: 0x002A6343 File Offset: 0x002A4543
		public vtkIntArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E026 RID: 122918
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIntArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E027 RID: 122919 RVA: 0x002A6354 File Offset: 0x002A4554
		public new static vtkIntArray New()
		{
			vtkIntArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIntArray.vtkIntArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E028 RID: 122920 RVA: 0x002A63A8 File Offset: 0x002A45A8
		public vtkIntArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkIntArray.vtkIntArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E029 RID: 122921 RVA: 0x002A63EC File Offset: 0x002A45EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E02A RID: 122922
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIntArray_ExtendedNew_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E02B RID: 122923 RVA: 0x002A63F8 File Offset: 0x002A45F8
		public static vtkIntArray ExtendedNew()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIntArray.vtkIntArray_ExtendedNew_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		// Token: 0x0601E02C RID: 122924
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIntArray_FastDownCast_02(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A faster alternative to SafeDownCast for downcasting vtkAbstractArrays.
		/// </summary>
		// Token: 0x0601E02D RID: 122925 RVA: 0x002A6464 File Offset: 0x002A4664
		public new static vtkIntArray FastDownCast(vtkAbstractArray source)
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIntArray.vtkIntArray_FastDownCast_02((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		// Token: 0x0601E02E RID: 122926
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntArray_GetDataTypeValueMax_03();

		/// <summary>
		/// Get the maximum data value in its native type.
		/// </summary>
		// Token: 0x0601E02F RID: 122927 RVA: 0x002A64E4 File Offset: 0x002A46E4
		public static int GetDataTypeValueMax()
		{
			return vtkIntArray.vtkIntArray_GetDataTypeValueMax_03();
		}

		// Token: 0x0601E030 RID: 122928
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntArray_GetDataTypeValueMin_04();

		/// <summary>
		/// Get the minimum data value in its native type.
		/// </summary>
		// Token: 0x0601E031 RID: 122929 RVA: 0x002A6500 File Offset: 0x002A4700
		public static int GetDataTypeValueMin()
		{
			return vtkIntArray.vtkIntArray_GetDataTypeValueMin_04();
		}

		// Token: 0x0601E032 RID: 122930
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIntArray_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E033 RID: 122931 RVA: 0x002A651C File Offset: 0x002A471C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIntArray.vtkIntArray_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E034 RID: 122932
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIntArray_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E035 RID: 122933 RVA: 0x002A653C File Offset: 0x002A473C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIntArray.vtkIntArray_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601E036 RID: 122934
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntArray_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E037 RID: 122935 RVA: 0x002A6558 File Offset: 0x002A4758
		public override int IsA(string type)
		{
			return vtkIntArray.vtkIntArray_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E038 RID: 122936
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIntArray_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E039 RID: 122937 RVA: 0x002A6578 File Offset: 0x002A4778
		public new static int IsTypeOf(string type)
		{
			return vtkIntArray.vtkIntArray_IsTypeOf_08(type);
		}

		// Token: 0x0601E03A RID: 122938
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIntArray_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E03B RID: 122939 RVA: 0x002A6594 File Offset: 0x002A4794
		public new vtkIntArray NewInstance()
		{
			vtkIntArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIntArray.vtkIntArray_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E03C RID: 122940
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIntArray_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E03D RID: 122941 RVA: 0x002A65F0 File Offset: 0x002A47F0
		public new static vtkIntArray SafeDownCast(vtkObjectBase o)
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIntArray.vtkIntArray_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FA9 RID: 8105
		public new const string MRFullTypeName = "Kitware.VTK.vtkIntArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FAA RID: 8106
		public new static readonly string MRClassNameKey = "class vtkIntArray";
	}
}
