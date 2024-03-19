using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000B3A RID: 2874
	public class vtkTypeFloat32Array : vtkFloatArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E152 RID: 123218 RVA: 0x002A8A87 File Offset: 0x002A6C87
		static vtkTypeFloat32Array()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTypeFloat32Array.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTypeFloat32Array"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E153 RID: 123219 RVA: 0x002A8AAF File Offset: 0x002A6CAF
		public vtkTypeFloat32Array(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E154 RID: 123220
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeFloat32Array_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E155 RID: 123221 RVA: 0x002A8AC0 File Offset: 0x002A6CC0
		public new static vtkTypeFloat32Array New()
		{
			vtkTypeFloat32Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeFloat32Array.vtkTypeFloat32Array_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeFloat32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E156 RID: 123222 RVA: 0x002A8B14 File Offset: 0x002A6D14
		public vtkTypeFloat32Array() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTypeFloat32Array.vtkTypeFloat32Array_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E157 RID: 123223 RVA: 0x002A8B58 File Offset: 0x002A6D58
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E158 RID: 123224
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeFloat32Array_FastDownCast_01(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E159 RID: 123225 RVA: 0x002A8B64 File Offset: 0x002A6D64
		public new static vtkTypeFloat32Array FastDownCast(vtkAbstractArray source)
		{
			vtkTypeFloat32Array vtkTypeFloat32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeFloat32Array.vtkTypeFloat32Array_FastDownCast_01((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeFloat32Array = (vtkTypeFloat32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeFloat32Array.Register(null);
				}
			}
			return vtkTypeFloat32Array;
		}

		// Token: 0x0601E15A RID: 123226
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeFloat32Array_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E15B RID: 123227 RVA: 0x002A8BE4 File Offset: 0x002A6DE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTypeFloat32Array.vtkTypeFloat32Array_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E15C RID: 123228
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeFloat32Array_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E15D RID: 123229 RVA: 0x002A8C04 File Offset: 0x002A6E04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTypeFloat32Array.vtkTypeFloat32Array_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E15E RID: 123230
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeFloat32Array_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E15F RID: 123231 RVA: 0x002A8C20 File Offset: 0x002A6E20
		public override int IsA(string type)
		{
			return vtkTypeFloat32Array.vtkTypeFloat32Array_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E160 RID: 123232
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeFloat32Array_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E161 RID: 123233 RVA: 0x002A8C40 File Offset: 0x002A6E40
		public new static int IsTypeOf(string type)
		{
			return vtkTypeFloat32Array.vtkTypeFloat32Array_IsTypeOf_05(type);
		}

		// Token: 0x0601E162 RID: 123234
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeFloat32Array_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E163 RID: 123235 RVA: 0x002A8C5C File Offset: 0x002A6E5C
		public new vtkTypeFloat32Array NewInstance()
		{
			vtkTypeFloat32Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeFloat32Array.vtkTypeFloat32Array_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeFloat32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E164 RID: 123236
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeFloat32Array_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E165 RID: 123237 RVA: 0x002A8CB8 File Offset: 0x002A6EB8
		public new static vtkTypeFloat32Array SafeDownCast(vtkObjectBase o)
		{
			vtkTypeFloat32Array vtkTypeFloat32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeFloat32Array.vtkTypeFloat32Array_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeFloat32Array = (vtkTypeFloat32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeFloat32Array.Register(null);
				}
			}
			return vtkTypeFloat32Array;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FC3 RID: 8131
		public new const string MRFullTypeName = "Kitware.VTK.vtkTypeFloat32Array";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FC4 RID: 8132
		public new static readonly string MRClassNameKey = "class vtkTypeFloat32Array";
	}
}
