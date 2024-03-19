using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnsignedLongArray
	/// </summary>
	/// <remarks>
	///    dynamic, self-adjusting array of unsigned long
	///
	/// vtkUnsignedLongArray is an array of values of type unsigned long.
	/// It provides methods for insertion and retrieval of values and will
	/// automatically resize itself to hold new data.
	///
	/// The C++ standard does not define the exact size of the unsigned long type,
	/// so use of this type directly is discouraged.  If an array of 32 bit
	/// unsigned integers is needed, prefer vtkTypeUInt32Array to this class.
	/// If an array of 64 bit unsigned integers is needed, prefer
	/// vtkUTypeInt64Array to this class.
	/// </remarks>
	// Token: 0x02000B83 RID: 2947
	public class vtkUnsignedLongArray : vtkDataArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601EBDE RID: 125918 RVA: 0x002B989D File Offset: 0x002B7A9D
		static vtkUnsignedLongArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnsignedLongArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnsignedLongArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601EBDF RID: 125919 RVA: 0x002B98C5 File Offset: 0x002B7AC5
		public vtkUnsignedLongArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601EBE0 RID: 125920
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedLongArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBE1 RID: 125921 RVA: 0x002B98D4 File Offset: 0x002B7AD4
		public new static vtkUnsignedLongArray New()
		{
			vtkUnsignedLongArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedLongArray.vtkUnsignedLongArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBE2 RID: 125922 RVA: 0x002B9928 File Offset: 0x002B7B28
		public vtkUnsignedLongArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnsignedLongArray.vtkUnsignedLongArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601EBE3 RID: 125923 RVA: 0x002B996C File Offset: 0x002B7B6C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601EBE4 RID: 125924
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedLongArray_ExtendedNew_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBE5 RID: 125925 RVA: 0x002B9978 File Offset: 0x002B7B78
		public static vtkUnsignedLongArray ExtendedNew()
		{
			vtkUnsignedLongArray vtkUnsignedLongArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedLongArray.vtkUnsignedLongArray_ExtendedNew_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedLongArray = (vtkUnsignedLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedLongArray.Register(null);
				}
			}
			return vtkUnsignedLongArray;
		}

		// Token: 0x0601EBE6 RID: 125926
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedLongArray_FastDownCast_02(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A faster alternative to SafeDownCast for downcasting vtkAbstractArrays.
		/// </summary>
		// Token: 0x0601EBE7 RID: 125927 RVA: 0x002B99E4 File Offset: 0x002B7BE4
		public new static vtkUnsignedLongArray FastDownCast(vtkAbstractArray source)
		{
			vtkUnsignedLongArray vtkUnsignedLongArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedLongArray.vtkUnsignedLongArray_FastDownCast_02((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedLongArray = (vtkUnsignedLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedLongArray.Register(null);
				}
			}
			return vtkUnsignedLongArray;
		}

		// Token: 0x0601EBE8 RID: 125928
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkUnsignedLongArray_GetDataTypeValueMax_03();

		/// <summary>
		/// Get the maximum data value in its native type.
		/// </summary>
		// Token: 0x0601EBE9 RID: 125929 RVA: 0x002B9A64 File Offset: 0x002B7C64
		public static uint GetDataTypeValueMax()
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_GetDataTypeValueMax_03();
		}

		// Token: 0x0601EBEA RID: 125930
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkUnsignedLongArray_GetDataTypeValueMin_04();

		/// <summary>
		/// Get the minimum data value in its native type.
		/// </summary>
		// Token: 0x0601EBEB RID: 125931 RVA: 0x002B9A80 File Offset: 0x002B7C80
		public static uint GetDataTypeValueMin()
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_GetDataTypeValueMin_04();
		}

		// Token: 0x0601EBEC RID: 125932
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnsignedLongArray_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBED RID: 125933 RVA: 0x002B9A9C File Offset: 0x002B7C9C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601EBEE RID: 125934
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnsignedLongArray_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBEF RID: 125935 RVA: 0x002B9ABC File Offset: 0x002B7CBC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601EBF0 RID: 125936
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnsignedLongArray_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBF1 RID: 125937 RVA: 0x002B9AD8 File Offset: 0x002B7CD8
		public override int IsA(string type)
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601EBF2 RID: 125938
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnsignedLongArray_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBF3 RID: 125939 RVA: 0x002B9AF8 File Offset: 0x002B7CF8
		public new static int IsTypeOf(string type)
		{
			return vtkUnsignedLongArray.vtkUnsignedLongArray_IsTypeOf_08(type);
		}

		// Token: 0x0601EBF4 RID: 125940
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedLongArray_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBF5 RID: 125941 RVA: 0x002B9B14 File Offset: 0x002B7D14
		public new vtkUnsignedLongArray NewInstance()
		{
			vtkUnsignedLongArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedLongArray.vtkUnsignedLongArray_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601EBF6 RID: 125942
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedLongArray_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBF7 RID: 125943 RVA: 0x002B9B70 File Offset: 0x002B7D70
		public new static vtkUnsignedLongArray SafeDownCast(vtkObjectBase o)
		{
			vtkUnsignedLongArray vtkUnsignedLongArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedLongArray.vtkUnsignedLongArray_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedLongArray = (vtkUnsignedLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedLongArray.Register(null);
				}
			}
			return vtkUnsignedLongArray;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020F1 RID: 8433
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnsignedLongArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020F2 RID: 8434
		public new static readonly string MRClassNameKey = "class vtkUnsignedLongArray";
	}
}
