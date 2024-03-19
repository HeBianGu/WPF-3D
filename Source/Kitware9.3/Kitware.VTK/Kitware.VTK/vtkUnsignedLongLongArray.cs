using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnsignedLongLongArray
	/// </summary>
	/// <remarks>
	///    dynamic, self-adjusting array of unsigned long long
	///
	/// vtkUnsignedLongLongArray is an array of values of type unsigned long long.
	/// It provides methods for insertion and retrieval of values and will
	/// automatically resize itself to hold new data.
	///
	/// This class should not be used directly, as it only exists on systems
	/// where the unsigned long long type is defined.  If you need an unsigned
	/// 64 bit integer data array, use vtkTypeUInt64Array instead.
	/// </remarks>
	// Token: 0x02000B37 RID: 2871
	public class vtkUnsignedLongLongArray : vtkDataArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E10A RID: 123146 RVA: 0x002A812F File Offset: 0x002A632F
		static vtkUnsignedLongLongArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnsignedLongLongArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnsignedLongLongArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E10B RID: 123147 RVA: 0x002A8157 File Offset: 0x002A6357
		public vtkUnsignedLongLongArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E10C RID: 123148
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedLongLongArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E10D RID: 123149 RVA: 0x002A8168 File Offset: 0x002A6368
		public new static vtkUnsignedLongLongArray New()
		{
			vtkUnsignedLongLongArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedLongLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E10E RID: 123150 RVA: 0x002A81BC File Offset: 0x002A63BC
		public vtkUnsignedLongLongArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E10F RID: 123151 RVA: 0x002A8200 File Offset: 0x002A6400
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E110 RID: 123152
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedLongLongArray_ExtendedNew_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E111 RID: 123153 RVA: 0x002A820C File Offset: 0x002A640C
		public static vtkUnsignedLongLongArray ExtendedNew()
		{
			vtkUnsignedLongLongArray vtkUnsignedLongLongArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_ExtendedNew_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedLongLongArray = (vtkUnsignedLongLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedLongLongArray.Register(null);
				}
			}
			return vtkUnsignedLongLongArray;
		}

		// Token: 0x0601E112 RID: 123154
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedLongLongArray_FastDownCast_02(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A faster alternative to SafeDownCast for downcasting vtkAbstractArrays.
		/// </summary>
		// Token: 0x0601E113 RID: 123155 RVA: 0x002A8278 File Offset: 0x002A6478
		public new static vtkUnsignedLongLongArray FastDownCast(vtkAbstractArray source)
		{
			vtkUnsignedLongLongArray vtkUnsignedLongLongArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_FastDownCast_02((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedLongLongArray = (vtkUnsignedLongLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedLongLongArray.Register(null);
				}
			}
			return vtkUnsignedLongLongArray;
		}

		// Token: 0x0601E114 RID: 123156
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkUnsignedLongLongArray_GetDataTypeValueMax_03();

		/// <summary>
		/// Get the maximum data value in its native type.
		/// </summary>
		// Token: 0x0601E115 RID: 123157 RVA: 0x002A82F8 File Offset: 0x002A64F8
		public static ulong GetDataTypeValueMax()
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_GetDataTypeValueMax_03();
		}

		// Token: 0x0601E116 RID: 123158
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkUnsignedLongLongArray_GetDataTypeValueMin_04();

		/// <summary>
		/// Get the minimum data value in its native type.
		/// </summary>
		// Token: 0x0601E117 RID: 123159 RVA: 0x002A8314 File Offset: 0x002A6514
		public static ulong GetDataTypeValueMin()
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_GetDataTypeValueMin_04();
		}

		// Token: 0x0601E118 RID: 123160
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnsignedLongLongArray_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E119 RID: 123161 RVA: 0x002A8330 File Offset: 0x002A6530
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E11A RID: 123162
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnsignedLongLongArray_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E11B RID: 123163 RVA: 0x002A8350 File Offset: 0x002A6550
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601E11C RID: 123164
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnsignedLongLongArray_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E11D RID: 123165 RVA: 0x002A836C File Offset: 0x002A656C
		public override int IsA(string type)
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E11E RID: 123166
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnsignedLongLongArray_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E11F RID: 123167 RVA: 0x002A838C File Offset: 0x002A658C
		public new static int IsTypeOf(string type)
		{
			return vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_IsTypeOf_08(type);
		}

		// Token: 0x0601E120 RID: 123168
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedLongLongArray_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E121 RID: 123169 RVA: 0x002A83A8 File Offset: 0x002A65A8
		public new vtkUnsignedLongLongArray NewInstance()
		{
			vtkUnsignedLongLongArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnsignedLongLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E122 RID: 123170
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnsignedLongLongArray_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E123 RID: 123171 RVA: 0x002A8404 File Offset: 0x002A6604
		public new static vtkUnsignedLongLongArray SafeDownCast(vtkObjectBase o)
		{
			vtkUnsignedLongLongArray vtkUnsignedLongLongArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnsignedLongLongArray.vtkUnsignedLongLongArray_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedLongLongArray = (vtkUnsignedLongLongArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedLongLongArray.Register(null);
				}
			}
			return vtkUnsignedLongLongArray;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FBD RID: 8125
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnsignedLongLongArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FBE RID: 8126
		public new static readonly string MRClassNameKey = "class vtkUnsignedLongLongArray";
	}
}
