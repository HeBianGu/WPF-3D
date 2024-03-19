using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnsignedIntArray
	/// </summary>
	/// <remarks>
	///    dynamic, self-adjusting array of unsigned int
	///
	/// vtkUnsignedIntArray is an array of values of type unsigned int.  It
	/// provides methods for insertion and retrieval of values and will
	/// automatically resize itself to hold new data.
	///
	/// The C++ standard does not define the exact size of the unsigned int type,
	/// so use of this type directly is discouraged.  If an array of 32 bit unsigned
	/// integers is needed, prefer vtkTypeUInt32Array to this class.
	/// </remarks>
	// Token: 0x02000B35 RID: 2869
	public class vtkUnsignedIntArray : vtkDataArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E0DC RID: 123100 RVA: 0x002A7B2B File Offset: 0x002A5D2B
		static vtkUnsignedIntArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnsignedIntArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnsignedIntArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E0DD RID: 123101 RVA: 0x002A7B53 File Offset: 0x002A5D53
		public vtkUnsignedIntArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E0DE RID: 123102
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedIntArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0DF RID: 123103 RVA: 0x002A7B64 File Offset: 0x002A5D64
		public new static vtkUnsignedIntArray New()
		{
			vtkUnsignedIntArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedIntArray.vtkUnsignedIntArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0E0 RID: 123104 RVA: 0x002A7BB8 File Offset: 0x002A5DB8
		public vtkUnsignedIntArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnsignedIntArray.vtkUnsignedIntArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E0E1 RID: 123105 RVA: 0x002A7BFC File Offset: 0x002A5DFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E0E2 RID: 123106
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedIntArray_ExtendedNew_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0E3 RID: 123107 RVA: 0x002A7C08 File Offset: 0x002A5E08
		public static vtkUnsignedIntArray ExtendedNew()
		{
			vtkUnsignedIntArray vtkUnsignedIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedIntArray.vtkUnsignedIntArray_ExtendedNew_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedIntArray = (vtkUnsignedIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedIntArray.Register(null);
				}
			}
			return vtkUnsignedIntArray;
		}

		// Token: 0x0601E0E4 RID: 123108
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedIntArray_FastDownCast_02(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A faster alternative to SafeDownCast for downcasting vtkAbstractArrays.
		/// </summary>
		// Token: 0x0601E0E5 RID: 123109 RVA: 0x002A7C74 File Offset: 0x002A5E74
		public new static vtkUnsignedIntArray FastDownCast(vtkAbstractArray source)
		{
			vtkUnsignedIntArray vtkUnsignedIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedIntArray.vtkUnsignedIntArray_FastDownCast_02((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedIntArray = (vtkUnsignedIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedIntArray.Register(null);
				}
			}
			return vtkUnsignedIntArray;
		}

		// Token: 0x0601E0E6 RID: 123110
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkUnsignedIntArray_GetDataTypeValueMax_03();

		/// <summary>
		/// Get the maximum data value in its native type.
		/// </summary>
		// Token: 0x0601E0E7 RID: 123111 RVA: 0x002A7CF4 File Offset: 0x002A5EF4
		public static uint GetDataTypeValueMax()
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_GetDataTypeValueMax_03();
		}

		// Token: 0x0601E0E8 RID: 123112
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkUnsignedIntArray_GetDataTypeValueMin_04();

		/// <summary>
		/// Get the minimum data value in its native type.
		/// </summary>
		// Token: 0x0601E0E9 RID: 123113 RVA: 0x002A7D10 File Offset: 0x002A5F10
		public static uint GetDataTypeValueMin()
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_GetDataTypeValueMin_04();
		}

		// Token: 0x0601E0EA RID: 123114
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnsignedIntArray_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0EB RID: 123115 RVA: 0x002A7D2C File Offset: 0x002A5F2C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E0EC RID: 123116
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnsignedIntArray_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0ED RID: 123117 RVA: 0x002A7D4C File Offset: 0x002A5F4C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601E0EE RID: 123118
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnsignedIntArray_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0EF RID: 123119 RVA: 0x002A7D68 File Offset: 0x002A5F68
		public override int IsA(string type)
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E0F0 RID: 123120
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnsignedIntArray_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0F1 RID: 123121 RVA: 0x002A7D88 File Offset: 0x002A5F88
		public new static int IsTypeOf(string type)
		{
			return vtkUnsignedIntArray.vtkUnsignedIntArray_IsTypeOf_08(type);
		}

		// Token: 0x0601E0F2 RID: 123122
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedIntArray_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0F3 RID: 123123 RVA: 0x002A7DA4 File Offset: 0x002A5FA4
		public new vtkUnsignedIntArray NewInstance()
		{
			vtkUnsignedIntArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedIntArray.vtkUnsignedIntArray_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E0F4 RID: 123124
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedIntArray_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E0F5 RID: 123125 RVA: 0x002A7E00 File Offset: 0x002A6000
		public new static vtkUnsignedIntArray SafeDownCast(vtkObjectBase o)
		{
			vtkUnsignedIntArray vtkUnsignedIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedIntArray.vtkUnsignedIntArray_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedIntArray = (vtkUnsignedIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedIntArray.Register(null);
				}
			}
			return vtkUnsignedIntArray;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FB9 RID: 8121
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnsignedIntArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FBA RID: 8122
		public new static readonly string MRClassNameKey = "class vtkUnsignedIntArray";
	}
}
