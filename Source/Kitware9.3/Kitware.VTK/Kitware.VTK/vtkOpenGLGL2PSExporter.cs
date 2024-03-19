using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLGL2PSExporter
	/// </summary>
	/// <remarks>
	///    OpenGL2 implementation of GL2PS exporter.
	///
	///
	/// Implementation of vtkGL2PSExporter for the OpenGL2 backend.
	/// </remarks>
	// Token: 0x020001B0 RID: 432
	public class vtkOpenGLGL2PSExporter : vtkGL2PSExporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005399 RID: 21401 RVA: 0x000798AD File Offset: 0x00077AAD
		static vtkOpenGLGL2PSExporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLGL2PSExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLGL2PSExporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600539A RID: 21402 RVA: 0x000798D5 File Offset: 0x00077AD5
		public vtkOpenGLGL2PSExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600539B RID: 21403
		[DllImport("Kitware.VTK.IOExportGL2PS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLGL2PSExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600539C RID: 21404 RVA: 0x000798E4 File Offset: 0x00077AE4
		public new static vtkOpenGLGL2PSExporter New()
		{
			vtkOpenGLGL2PSExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLGL2PSExporter.vtkOpenGLGL2PSExporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLGL2PSExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600539D RID: 21405 RVA: 0x00079938 File Offset: 0x00077B38
		public vtkOpenGLGL2PSExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLGL2PSExporter.vtkOpenGLGL2PSExporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600539E RID: 21406 RVA: 0x0007997C File Offset: 0x00077B7C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600539F RID: 21407
		[DllImport("Kitware.VTK.IOExportGL2PS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLGL2PSExporter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053A0 RID: 21408 RVA: 0x00079988 File Offset: 0x00077B88
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLGL2PSExporter.vtkOpenGLGL2PSExporter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060053A1 RID: 21409
		[DllImport("Kitware.VTK.IOExportGL2PS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLGL2PSExporter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053A2 RID: 21410 RVA: 0x000799A8 File Offset: 0x00077BA8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLGL2PSExporter.vtkOpenGLGL2PSExporter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060053A3 RID: 21411
		[DllImport("Kitware.VTK.IOExportGL2PS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLGL2PSExporter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053A4 RID: 21412 RVA: 0x000799C4 File Offset: 0x00077BC4
		public override int IsA(string type)
		{
			return vtkOpenGLGL2PSExporter.vtkOpenGLGL2PSExporter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060053A5 RID: 21413
		[DllImport("Kitware.VTK.IOExportGL2PS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLGL2PSExporter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053A6 RID: 21414 RVA: 0x000799E4 File Offset: 0x00077BE4
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLGL2PSExporter.vtkOpenGLGL2PSExporter_IsTypeOf_04(type);
		}

		// Token: 0x060053A7 RID: 21415
		[DllImport("Kitware.VTK.IOExportGL2PS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLGL2PSExporter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053A8 RID: 21416 RVA: 0x00079A00 File Offset: 0x00077C00
		public new vtkOpenGLGL2PSExporter NewInstance()
		{
			vtkOpenGLGL2PSExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLGL2PSExporter.vtkOpenGLGL2PSExporter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLGL2PSExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060053A9 RID: 21417
		[DllImport("Kitware.VTK.IOExportGL2PS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLGL2PSExporter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053AA RID: 21418 RVA: 0x00079A5C File Offset: 0x00077C5C
		public new static vtkOpenGLGL2PSExporter SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLGL2PSExporter vtkOpenGLGL2PSExporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLGL2PSExporter.vtkOpenGLGL2PSExporter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLGL2PSExporter = (vtkOpenGLGL2PSExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLGL2PSExporter.Register(null);
				}
			}
			return vtkOpenGLGL2PSExporter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007CB RID: 1995
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLGL2PSExporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007CC RID: 1996
		public new static readonly string MRClassNameKey = "class vtkOpenGLGL2PSExporter";
	}
}
