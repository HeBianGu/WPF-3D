using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDoubleArray
	/// </summary>
	/// <remarks>
	///    dynamic, self-adjusting array of double
	///
	/// vtkDoubleArray is an array of values of type double.  It provides
	/// methods for insertion and retrieval of values and will
	/// automatically resize itself to hold new data.
	/// </remarks>
	// Token: 0x02000B3B RID: 2875
	public class vtkDoubleArray : vtkDataArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E166 RID: 123238 RVA: 0x002A8D37 File Offset: 0x002A6F37
		static vtkDoubleArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDoubleArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDoubleArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E167 RID: 123239 RVA: 0x002A8D5F File Offset: 0x002A6F5F
		public vtkDoubleArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E168 RID: 123240
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDoubleArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E169 RID: 123241 RVA: 0x002A8D70 File Offset: 0x002A6F70
		public new static vtkDoubleArray New()
		{
			vtkDoubleArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDoubleArray.vtkDoubleArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E16A RID: 123242 RVA: 0x002A8DC4 File Offset: 0x002A6FC4
		public vtkDoubleArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDoubleArray.vtkDoubleArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E16B RID: 123243 RVA: 0x002A8E08 File Offset: 0x002A7008
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E16C RID: 123244
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDoubleArray_ExtendedNew_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E16D RID: 123245 RVA: 0x002A8E14 File Offset: 0x002A7014
		public static vtkDoubleArray ExtendedNew()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDoubleArray.vtkDoubleArray_ExtendedNew_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x0601E16E RID: 123246
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDoubleArray_FastDownCast_02(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A faster alternative to SafeDownCast for downcasting vtkAbstractArrays.
		/// </summary>
		// Token: 0x0601E16F RID: 123247 RVA: 0x002A8E80 File Offset: 0x002A7080
		public new static vtkDoubleArray FastDownCast(vtkAbstractArray source)
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDoubleArray.vtkDoubleArray_FastDownCast_02((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x0601E170 RID: 123248
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDoubleArray_GetDataTypeValueMax_03();

		/// <summary>
		/// Get the maximum data value in its native type.
		/// </summary>
		// Token: 0x0601E171 RID: 123249 RVA: 0x002A8F00 File Offset: 0x002A7100
		public static double GetDataTypeValueMax()
		{
			return vtkDoubleArray.vtkDoubleArray_GetDataTypeValueMax_03();
		}

		// Token: 0x0601E172 RID: 123250
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDoubleArray_GetDataTypeValueMin_04();

		/// <summary>
		/// Get the minimum data value in its native type.
		/// </summary>
		// Token: 0x0601E173 RID: 123251 RVA: 0x002A8F1C File Offset: 0x002A711C
		public static double GetDataTypeValueMin()
		{
			return vtkDoubleArray.vtkDoubleArray_GetDataTypeValueMin_04();
		}

		// Token: 0x0601E174 RID: 123252
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDoubleArray_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E175 RID: 123253 RVA: 0x002A8F38 File Offset: 0x002A7138
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDoubleArray.vtkDoubleArray_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E176 RID: 123254
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDoubleArray_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E177 RID: 123255 RVA: 0x002A8F58 File Offset: 0x002A7158
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDoubleArray.vtkDoubleArray_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601E178 RID: 123256
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDoubleArray_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E179 RID: 123257 RVA: 0x002A8F74 File Offset: 0x002A7174
		public override int IsA(string type)
		{
			return vtkDoubleArray.vtkDoubleArray_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E17A RID: 123258
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDoubleArray_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E17B RID: 123259 RVA: 0x002A8F94 File Offset: 0x002A7194
		public new static int IsTypeOf(string type)
		{
			return vtkDoubleArray.vtkDoubleArray_IsTypeOf_08(type);
		}

		// Token: 0x0601E17C RID: 123260
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDoubleArray_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E17D RID: 123261 RVA: 0x002A8FB0 File Offset: 0x002A71B0
		public new vtkDoubleArray NewInstance()
		{
			vtkDoubleArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDoubleArray.vtkDoubleArray_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E17E RID: 123262
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDoubleArray_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E17F RID: 123263 RVA: 0x002A900C File Offset: 0x002A720C
		public new static vtkDoubleArray SafeDownCast(vtkObjectBase o)
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDoubleArray.vtkDoubleArray_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FC5 RID: 8133
		public new const string MRFullTypeName = "Kitware.VTK.vtkDoubleArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FC6 RID: 8134
		public new static readonly string MRClassNameKey = "class vtkDoubleArray";
	}
}
