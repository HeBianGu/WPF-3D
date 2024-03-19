using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnsignedShortArray
	/// </summary>
	/// <remarks>
	///    dynamic, self-adjusting array of unsigned short
	///
	/// vtkUnsignedShortArray is an array of values of type unsigned short.
	/// It provides methods for insertion and retrieval of values and will
	/// automatically resize itself to hold new data.
	///
	/// The C++ standard does not define the exact size of the unsigned short type,
	/// so use of this type directly is discouraged.  If an array of 16 bit
	/// unsigned integers is needed, prefer vtkTypeUInt16Array to this class.
	/// </remarks>
	// Token: 0x02000B33 RID: 2867
	public class vtkUnsignedShortArray : vtkDataArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E0AE RID: 123054 RVA: 0x002A7527 File Offset: 0x002A5727
		static vtkUnsignedShortArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnsignedShortArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnsignedShortArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E0AF RID: 123055 RVA: 0x002A754F File Offset: 0x002A574F
		public vtkUnsignedShortArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E0B0 RID: 123056
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedShortArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0B1 RID: 123057 RVA: 0x002A7560 File Offset: 0x002A5760
		public new static vtkUnsignedShortArray New()
		{
			vtkUnsignedShortArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedShortArray.vtkUnsignedShortArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedShortArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0B2 RID: 123058 RVA: 0x002A75B4 File Offset: 0x002A57B4
		public vtkUnsignedShortArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnsignedShortArray.vtkUnsignedShortArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E0B3 RID: 123059 RVA: 0x002A75F8 File Offset: 0x002A57F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E0B4 RID: 123060
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedShortArray_ExtendedNew_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0B5 RID: 123061 RVA: 0x002A7604 File Offset: 0x002A5804
		public static vtkUnsignedShortArray ExtendedNew()
		{
			vtkUnsignedShortArray vtkUnsignedShortArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedShortArray.vtkUnsignedShortArray_ExtendedNew_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedShortArray = (vtkUnsignedShortArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedShortArray.Register(null);
				}
			}
			return vtkUnsignedShortArray;
		}

		// Token: 0x0601E0B6 RID: 123062
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedShortArray_FastDownCast_02(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A faster alternative to SafeDownCast for downcasting vtkAbstractArrays.
		/// </summary>
		// Token: 0x0601E0B7 RID: 123063 RVA: 0x002A7670 File Offset: 0x002A5870
		public new static vtkUnsignedShortArray FastDownCast(vtkAbstractArray source)
		{
			vtkUnsignedShortArray vtkUnsignedShortArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedShortArray.vtkUnsignedShortArray_FastDownCast_02((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedShortArray = (vtkUnsignedShortArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedShortArray.Register(null);
				}
			}
			return vtkUnsignedShortArray;
		}

		// Token: 0x0601E0B8 RID: 123064
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkUnsignedShortArray_GetDataTypeValueMax_03();

		/// <summary>
		/// Get the maximum data value in its native type.
		/// </summary>
		// Token: 0x0601E0B9 RID: 123065 RVA: 0x002A76F0 File Offset: 0x002A58F0
		public static ushort GetDataTypeValueMax()
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_GetDataTypeValueMax_03();
		}

		// Token: 0x0601E0BA RID: 123066
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkUnsignedShortArray_GetDataTypeValueMin_04();

		/// <summary>
		/// Get the minimum data value in its native type.
		/// </summary>
		// Token: 0x0601E0BB RID: 123067 RVA: 0x002A770C File Offset: 0x002A590C
		public static ushort GetDataTypeValueMin()
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_GetDataTypeValueMin_04();
		}

		// Token: 0x0601E0BC RID: 123068
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnsignedShortArray_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0BD RID: 123069 RVA: 0x002A7728 File Offset: 0x002A5928
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E0BE RID: 123070
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnsignedShortArray_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0BF RID: 123071 RVA: 0x002A7748 File Offset: 0x002A5948
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601E0C0 RID: 123072
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnsignedShortArray_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0C1 RID: 123073 RVA: 0x002A7764 File Offset: 0x002A5964
		public override int IsA(string type)
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E0C2 RID: 123074
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnsignedShortArray_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0C3 RID: 123075 RVA: 0x002A7784 File Offset: 0x002A5984
		public new static int IsTypeOf(string type)
		{
			return vtkUnsignedShortArray.vtkUnsignedShortArray_IsTypeOf_08(type);
		}

		// Token: 0x0601E0C4 RID: 123076
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedShortArray_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0C5 RID: 123077 RVA: 0x002A77A0 File Offset: 0x002A59A0
		public new vtkUnsignedShortArray NewInstance()
		{
			vtkUnsignedShortArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedShortArray.vtkUnsignedShortArray_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedShortArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E0C6 RID: 123078
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedShortArray_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0C7 RID: 123079 RVA: 0x002A77FC File Offset: 0x002A59FC
		public new static vtkUnsignedShortArray SafeDownCast(vtkObjectBase o)
		{
			vtkUnsignedShortArray vtkUnsignedShortArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedShortArray.vtkUnsignedShortArray_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedShortArray = (vtkUnsignedShortArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedShortArray.Register(null);
				}
			}
			return vtkUnsignedShortArray;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FB5 RID: 8117
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnsignedShortArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FB6 RID: 8118
		public new static readonly string MRClassNameKey = "class vtkUnsignedShortArray";
	}
}
