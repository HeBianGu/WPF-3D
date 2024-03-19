using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLongLongArray
	/// </summary>
	/// <remarks>
	///    dynamic, self-adjusting array of long long
	///
	/// vtkLongLongArray is an array of values of type long long.
	/// It provides methods for insertion and retrieval of values and will
	/// automatically resize itself to hold new data.
	///
	/// This class should not be used directly, as it only exists on systems
	/// where the long long type is defined.  If you need a 64 bit integer
	/// data array, use vtkTypeInt64Array instead.
	/// </remarks>
	// Token: 0x02000B2F RID: 2863
	public class vtkLongLongArray : vtkDataArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E052 RID: 122962 RVA: 0x002A691F File Offset: 0x002A4B1F
		static vtkLongLongArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLongLongArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLongLongArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E053 RID: 122963 RVA: 0x002A6947 File Offset: 0x002A4B47
		public vtkLongLongArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E054 RID: 122964
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLongLongArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E055 RID: 122965 RVA: 0x002A6958 File Offset: 0x002A4B58
		public new static vtkLongLongArray New()
		{
			vtkLongLongArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLongLongArray.vtkLongLongArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLongLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E056 RID: 122966 RVA: 0x002A69AC File Offset: 0x002A4BAC
		public vtkLongLongArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLongLongArray.vtkLongLongArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E057 RID: 122967 RVA: 0x002A69F0 File Offset: 0x002A4BF0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E058 RID: 122968
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLongLongArray_ExtendedNew_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E059 RID: 122969 RVA: 0x002A69FC File Offset: 0x002A4BFC
		public static vtkLongLongArray ExtendedNew()
		{
			vtkLongLongArray vtkLongLongArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLongLongArray.vtkLongLongArray_ExtendedNew_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLongLongArray = (vtkLongLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLongLongArray.Register(null);
				}
			}
			return vtkLongLongArray;
		}

		// Token: 0x0601E05A RID: 122970
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLongLongArray_FastDownCast_02(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A faster alternative to SafeDownCast for downcasting vtkAbstractArrays.
		/// </summary>
		// Token: 0x0601E05B RID: 122971 RVA: 0x002A6A68 File Offset: 0x002A4C68
		public new static vtkLongLongArray FastDownCast(vtkAbstractArray source)
		{
			vtkLongLongArray vtkLongLongArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLongLongArray.vtkLongLongArray_FastDownCast_02((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLongLongArray = (vtkLongLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLongLongArray.Register(null);
				}
			}
			return vtkLongLongArray;
		}

		// Token: 0x0601E05C RID: 122972
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLongLongArray_GetDataTypeValueMax_03();

		/// <summary>
		/// Get the maximum data value in its native type.
		/// </summary>
		// Token: 0x0601E05D RID: 122973 RVA: 0x002A6AE8 File Offset: 0x002A4CE8
		public static long GetDataTypeValueMax()
		{
			return vtkLongLongArray.vtkLongLongArray_GetDataTypeValueMax_03();
		}

		// Token: 0x0601E05E RID: 122974
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLongLongArray_GetDataTypeValueMin_04();

		/// <summary>
		/// Get the minimum data value in its native type.
		/// </summary>
		// Token: 0x0601E05F RID: 122975 RVA: 0x002A6B04 File Offset: 0x002A4D04
		public static long GetDataTypeValueMin()
		{
			return vtkLongLongArray.vtkLongLongArray_GetDataTypeValueMin_04();
		}

		// Token: 0x0601E060 RID: 122976
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLongLongArray_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E061 RID: 122977 RVA: 0x002A6B20 File Offset: 0x002A4D20
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLongLongArray.vtkLongLongArray_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E062 RID: 122978
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLongLongArray_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E063 RID: 122979 RVA: 0x002A6B40 File Offset: 0x002A4D40
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLongLongArray.vtkLongLongArray_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601E064 RID: 122980
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLongLongArray_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E065 RID: 122981 RVA: 0x002A6B5C File Offset: 0x002A4D5C
		public override int IsA(string type)
		{
			return vtkLongLongArray.vtkLongLongArray_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E066 RID: 122982
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLongLongArray_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E067 RID: 122983 RVA: 0x002A6B7C File Offset: 0x002A4D7C
		public new static int IsTypeOf(string type)
		{
			return vtkLongLongArray.vtkLongLongArray_IsTypeOf_08(type);
		}

		// Token: 0x0601E068 RID: 122984
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLongLongArray_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E069 RID: 122985 RVA: 0x002A6B98 File Offset: 0x002A4D98
		public new vtkLongLongArray NewInstance()
		{
			vtkLongLongArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLongLongArray.vtkLongLongArray_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLongLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E06A RID: 122986
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLongLongArray_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E06B RID: 122987 RVA: 0x002A6BF4 File Offset: 0x002A4DF4
		public new static vtkLongLongArray SafeDownCast(vtkObjectBase o)
		{
			vtkLongLongArray vtkLongLongArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLongLongArray.vtkLongLongArray_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLongLongArray = (vtkLongLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLongLongArray.Register(null);
				}
			}
			return vtkLongLongArray;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FAD RID: 8109
		public new const string MRFullTypeName = "Kitware.VTK.vtkLongLongArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FAE RID: 8110
		public new static readonly string MRClassNameKey = "class vtkLongLongArray";
	}
}
