using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000B3C RID: 2876
	public class vtkTypeFloat64Array : vtkDoubleArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E180 RID: 123264 RVA: 0x002A908B File Offset: 0x002A728B
		static vtkTypeFloat64Array()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTypeFloat64Array.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTypeFloat64Array"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E181 RID: 123265 RVA: 0x002A90B3 File Offset: 0x002A72B3
		public vtkTypeFloat64Array(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E182 RID: 123266
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeFloat64Array_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E183 RID: 123267 RVA: 0x002A90C4 File Offset: 0x002A72C4
		public new static vtkTypeFloat64Array New()
		{
			vtkTypeFloat64Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeFloat64Array.vtkTypeFloat64Array_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeFloat64Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E184 RID: 123268 RVA: 0x002A9118 File Offset: 0x002A7318
		public vtkTypeFloat64Array() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTypeFloat64Array.vtkTypeFloat64Array_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E185 RID: 123269 RVA: 0x002A915C File Offset: 0x002A735C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E186 RID: 123270
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeFloat64Array_FastDownCast_01(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E187 RID: 123271 RVA: 0x002A9168 File Offset: 0x002A7368
		public new static vtkTypeFloat64Array FastDownCast(vtkAbstractArray source)
		{
			vtkTypeFloat64Array vtkTypeFloat64Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeFloat64Array.vtkTypeFloat64Array_FastDownCast_01((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeFloat64Array = (vtkTypeFloat64Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeFloat64Array.Register(null);
				}
			}
			return vtkTypeFloat64Array;
		}

		// Token: 0x0601E188 RID: 123272
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeFloat64Array_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E189 RID: 123273 RVA: 0x002A91E8 File Offset: 0x002A73E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTypeFloat64Array.vtkTypeFloat64Array_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E18A RID: 123274
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeFloat64Array_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E18B RID: 123275 RVA: 0x002A9208 File Offset: 0x002A7408
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTypeFloat64Array.vtkTypeFloat64Array_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E18C RID: 123276
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeFloat64Array_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E18D RID: 123277 RVA: 0x002A9224 File Offset: 0x002A7424
		public override int IsA(string type)
		{
			return vtkTypeFloat64Array.vtkTypeFloat64Array_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E18E RID: 123278
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeFloat64Array_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E18F RID: 123279 RVA: 0x002A9244 File Offset: 0x002A7444
		public new static int IsTypeOf(string type)
		{
			return vtkTypeFloat64Array.vtkTypeFloat64Array_IsTypeOf_05(type);
		}

		// Token: 0x0601E190 RID: 123280
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeFloat64Array_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E191 RID: 123281 RVA: 0x002A9260 File Offset: 0x002A7460
		public new vtkTypeFloat64Array NewInstance()
		{
			vtkTypeFloat64Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeFloat64Array.vtkTypeFloat64Array_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeFloat64Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E192 RID: 123282
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeFloat64Array_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E193 RID: 123283 RVA: 0x002A92BC File Offset: 0x002A74BC
		public new static vtkTypeFloat64Array SafeDownCast(vtkObjectBase o)
		{
			vtkTypeFloat64Array vtkTypeFloat64Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeFloat64Array.vtkTypeFloat64Array_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeFloat64Array = (vtkTypeFloat64Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeFloat64Array.Register(null);
				}
			}
			return vtkTypeFloat64Array;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FC7 RID: 8135
		public new const string MRFullTypeName = "Kitware.VTK.vtkTypeFloat64Array";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FC8 RID: 8136
		public new static readonly string MRClassNameKey = "class vtkTypeFloat64Array";
	}
}
