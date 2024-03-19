using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenXRModel
	/// </summary>
	/// <remarks>
	///    OpenXR device model
	///
	/// This internal class is used to load models
	/// such as for the trackers and controllers and to
	/// render them in the scene
	/// </remarks>
	// Token: 0x020000A9 RID: 169
	public class vtkOpenXRModel : vtkVRModel
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060023EA RID: 9194 RVA: 0x00035D01 File Offset: 0x00033F01
		static vtkOpenXRModel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenXRModel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenXRModel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060023EB RID: 9195 RVA: 0x00035D29 File Offset: 0x00033F29
		public vtkOpenXRModel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060023EC RID: 9196
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRModel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023ED RID: 9197 RVA: 0x00035D38 File Offset: 0x00033F38
		public new static vtkOpenXRModel New()
		{
			vtkOpenXRModel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRModel.vtkOpenXRModel_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenXRModel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023EE RID: 9198 RVA: 0x00035D8C File Offset: 0x00033F8C
		public vtkOpenXRModel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenXRModel.vtkOpenXRModel_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060023EF RID: 9199 RVA: 0x00035DD0 File Offset: 0x00033FD0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060023F0 RID: 9200
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenXRModel_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023F1 RID: 9201 RVA: 0x00035DDC File Offset: 0x00033FDC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenXRModel.vtkOpenXRModel_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060023F2 RID: 9202
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenXRModel_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023F3 RID: 9203 RVA: 0x00035DFC File Offset: 0x00033FFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenXRModel.vtkOpenXRModel_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060023F4 RID: 9204
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenXRModel_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023F5 RID: 9205 RVA: 0x00035E18 File Offset: 0x00034018
		public override int IsA(string type)
		{
			return vtkOpenXRModel.vtkOpenXRModel_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060023F6 RID: 9206
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenXRModel_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023F7 RID: 9207 RVA: 0x00035E38 File Offset: 0x00034038
		public new static int IsTypeOf(string type)
		{
			return vtkOpenXRModel.vtkOpenXRModel_IsTypeOf_04(type);
		}

		// Token: 0x060023F8 RID: 9208
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRModel_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023F9 RID: 9209 RVA: 0x00035E54 File Offset: 0x00034054
		public new vtkOpenXRModel NewInstance()
		{
			vtkOpenXRModel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRModel.vtkOpenXRModel_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenXRModel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060023FA RID: 9210
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRModel_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023FB RID: 9211 RVA: 0x00035EB0 File Offset: 0x000340B0
		public new static vtkOpenXRModel SafeDownCast(vtkObjectBase o)
		{
			vtkOpenXRModel vtkOpenXRModel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRModel.vtkOpenXRModel_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenXRModel = (vtkOpenXRModel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenXRModel.Register(null);
				}
			}
			return vtkOpenXRModel;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000535 RID: 1333
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenXRModel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000536 RID: 1334
		public new static readonly string MRClassNameKey = "class vtkOpenXRModel";
	}
}
