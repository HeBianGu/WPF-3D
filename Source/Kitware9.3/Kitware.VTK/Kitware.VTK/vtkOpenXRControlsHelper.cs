using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenXRControlsHelper
	/// </summary>
	/// <remarks>
	///    Tooltip helper explaining controls
	/// Helper class to draw one tooltip per button around the controller.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVRPanelRepresentation
	/// </seealso>
	// Token: 0x020000A7 RID: 167
	public class vtkOpenXRControlsHelper : vtkVRControlsHelper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060023B3 RID: 9139 RVA: 0x00035776 File Offset: 0x00033976
		static vtkOpenXRControlsHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenXRControlsHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenXRControlsHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060023B4 RID: 9140 RVA: 0x0003579E File Offset: 0x0003399E
		public vtkOpenXRControlsHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060023B5 RID: 9141
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRControlsHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060023B6 RID: 9142 RVA: 0x000357AC File Offset: 0x000339AC
		public new static vtkOpenXRControlsHelper New()
		{
			vtkOpenXRControlsHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRControlsHelper.vtkOpenXRControlsHelper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenXRControlsHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060023B7 RID: 9143 RVA: 0x00035800 File Offset: 0x00033A00
		public vtkOpenXRControlsHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenXRControlsHelper.vtkOpenXRControlsHelper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060023B8 RID: 9144 RVA: 0x00035844 File Offset: 0x00033A44
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060023B9 RID: 9145
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenXRControlsHelper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060023BA RID: 9146 RVA: 0x00035850 File Offset: 0x00033A50
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenXRControlsHelper.vtkOpenXRControlsHelper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060023BB RID: 9147
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenXRControlsHelper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060023BC RID: 9148 RVA: 0x00035870 File Offset: 0x00033A70
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenXRControlsHelper.vtkOpenXRControlsHelper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060023BD RID: 9149
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenXRControlsHelper_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060023BE RID: 9150 RVA: 0x0003588C File Offset: 0x00033A8C
		public override int IsA(string type)
		{
			return vtkOpenXRControlsHelper.vtkOpenXRControlsHelper_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060023BF RID: 9151
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenXRControlsHelper_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060023C0 RID: 9152 RVA: 0x000358AC File Offset: 0x00033AAC
		public new static int IsTypeOf(string type)
		{
			return vtkOpenXRControlsHelper.vtkOpenXRControlsHelper_IsTypeOf_04(type);
		}

		// Token: 0x060023C1 RID: 9153
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRControlsHelper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060023C2 RID: 9154 RVA: 0x000358C8 File Offset: 0x00033AC8
		public new vtkOpenXRControlsHelper NewInstance()
		{
			vtkOpenXRControlsHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRControlsHelper.vtkOpenXRControlsHelper_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenXRControlsHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060023C3 RID: 9155
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRControlsHelper_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060023C4 RID: 9156 RVA: 0x00035924 File Offset: 0x00033B24
		public new static vtkOpenXRControlsHelper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenXRControlsHelper vtkOpenXRControlsHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRControlsHelper.vtkOpenXRControlsHelper_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenXRControlsHelper = (vtkOpenXRControlsHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenXRControlsHelper.Register(null);
				}
			}
			return vtkOpenXRControlsHelper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000531 RID: 1329
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenXRControlsHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000532 RID: 1330
		public new static readonly string MRClassNameKey = "class vtkOpenXRControlsHelper";
	}
}
