using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkShortArray
	/// </summary>
	/// <remarks>
	///    dynamic, self-adjusting array of short
	///
	/// vtkShortArray is an array of values of type short.  It provides
	/// methods for insertion and retrieval of values and will
	/// automatically resize itself to hold new data.
	///
	/// The C++ standard does not define the exact size of the short type,
	/// so use of this type directly is discouraged.  If an array of 16 bit
	/// integers is needed, prefer vtkTypeInt16Array to this class.
	/// </remarks>
	// Token: 0x02000B2B RID: 2859
	public class vtkShortArray : vtkDataArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DFF6 RID: 122870 RVA: 0x002A5D17 File Offset: 0x002A3F17
		static vtkShortArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShortArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShortArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DFF7 RID: 122871 RVA: 0x002A5D3F File Offset: 0x002A3F3F
		public vtkShortArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DFF8 RID: 122872
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShortArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DFF9 RID: 122873 RVA: 0x002A5D50 File Offset: 0x002A3F50
		public new static vtkShortArray New()
		{
			vtkShortArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShortArray.vtkShortArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShortArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DFFA RID: 122874 RVA: 0x002A5DA4 File Offset: 0x002A3FA4
		public vtkShortArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkShortArray.vtkShortArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DFFB RID: 122875 RVA: 0x002A5DE8 File Offset: 0x002A3FE8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DFFC RID: 122876
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShortArray_ExtendedNew_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DFFD RID: 122877 RVA: 0x002A5DF4 File Offset: 0x002A3FF4
		public static vtkShortArray ExtendedNew()
		{
			vtkShortArray vtkShortArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShortArray.vtkShortArray_ExtendedNew_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShortArray = (vtkShortArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShortArray.Register(null);
				}
			}
			return vtkShortArray;
		}

		// Token: 0x0601DFFE RID: 122878
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShortArray_FastDownCast_02(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A faster alternative to SafeDownCast for downcasting vtkAbstractArrays.
		/// </summary>
		// Token: 0x0601DFFF RID: 122879 RVA: 0x002A5E60 File Offset: 0x002A4060
		public new static vtkShortArray FastDownCast(vtkAbstractArray source)
		{
			vtkShortArray vtkShortArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShortArray.vtkShortArray_FastDownCast_02((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShortArray = (vtkShortArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShortArray.Register(null);
				}
			}
			return vtkShortArray;
		}

		// Token: 0x0601E000 RID: 122880
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern short vtkShortArray_GetDataTypeValueMax_03();

		/// <summary>
		/// Get the maximum data value in its native type.
		/// </summary>
		// Token: 0x0601E001 RID: 122881 RVA: 0x002A5EE0 File Offset: 0x002A40E0
		public static short GetDataTypeValueMax()
		{
			return vtkShortArray.vtkShortArray_GetDataTypeValueMax_03();
		}

		// Token: 0x0601E002 RID: 122882
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern short vtkShortArray_GetDataTypeValueMin_04();

		/// <summary>
		/// Get the minimum data value in its native type.
		/// </summary>
		// Token: 0x0601E003 RID: 122883 RVA: 0x002A5EFC File Offset: 0x002A40FC
		public static short GetDataTypeValueMin()
		{
			return vtkShortArray.vtkShortArray_GetDataTypeValueMin_04();
		}

		// Token: 0x0601E004 RID: 122884
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShortArray_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E005 RID: 122885 RVA: 0x002A5F18 File Offset: 0x002A4118
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkShortArray.vtkShortArray_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E006 RID: 122886
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShortArray_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E007 RID: 122887 RVA: 0x002A5F38 File Offset: 0x002A4138
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkShortArray.vtkShortArray_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601E008 RID: 122888
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShortArray_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E009 RID: 122889 RVA: 0x002A5F54 File Offset: 0x002A4154
		public override int IsA(string type)
		{
			return vtkShortArray.vtkShortArray_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E00A RID: 122890
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShortArray_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E00B RID: 122891 RVA: 0x002A5F74 File Offset: 0x002A4174
		public new static int IsTypeOf(string type)
		{
			return vtkShortArray.vtkShortArray_IsTypeOf_08(type);
		}

		// Token: 0x0601E00C RID: 122892
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShortArray_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E00D RID: 122893 RVA: 0x002A5F90 File Offset: 0x002A4190
		public new vtkShortArray NewInstance()
		{
			vtkShortArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShortArray.vtkShortArray_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShortArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E00E RID: 122894
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShortArray_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E00F RID: 122895 RVA: 0x002A5FEC File Offset: 0x002A41EC
		public new static vtkShortArray SafeDownCast(vtkObjectBase o)
		{
			vtkShortArray vtkShortArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShortArray.vtkShortArray_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShortArray = (vtkShortArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShortArray.Register(null);
				}
			}
			return vtkShortArray;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FA5 RID: 8101
		public new const string MRFullTypeName = "Kitware.VTK.vtkShortArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FA6 RID: 8102
		public new static readonly string MRClassNameKey = "class vtkShortArray";
	}
}
