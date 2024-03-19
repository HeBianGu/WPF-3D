using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkXMLWriter2
	/// </summary>
	/// <remarks>
	///  base class for new-style XML Writers
	///
	/// vtkXMLWriter2 is designed to eventually replace vtkXMLWriter. This class and
	/// its subclasses model a simpler design for the XML writers that does not rely
	/// on complex class hierarchy which can cumbersome to develop and debug.
	///
	/// vtkXMLWriter2 assumes parallel support. While MPI is not required,
	/// vtkXMLWriter2 accesses vtkMultiProcessController and uses it to correctly
	/// handle distributed execution. This avoids the need for having a parallel
	/// variant of the writers as `vtkXMLWriter` hierarchy requires. This further
	/// simplifies the development and debugging of these writers.
	///
	/// A typical XML writer may generate multiple artifacts all of which should be
	/// cleaned up if the write fails. vtkXMLWriter2 provides API that the subclasses
	/// can use to register such artifacts. If `RequestData` returns failure, then
	/// all such artifacts are cleaned up.
	/// </remarks>
	// Token: 0x0200013C RID: 316
	public abstract class vtkXMLWriter2 : vtkXMLWriterBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003E39 RID: 15929 RVA: 0x0005AD77 File Offset: 0x00058F77
		static vtkXMLWriter2()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLWriter2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLWriter2"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003E3A RID: 15930 RVA: 0x0005AD9F File Offset: 0x00058F9F
		public vtkXMLWriter2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003E3B RID: 15931 RVA: 0x0005ADAD File Offset: 0x00058FAD
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003E3C RID: 15932
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLWriter2_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the controller to use. By default, initialized to
		/// `vtkMultiProcessController::GetGlobalController`. The controller is used to
		/// determine which piece to request from upstream.
		/// </summary>
		// Token: 0x06003E3D RID: 15933 RVA: 0x0005ADB8 File Offset: 0x00058FB8
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLWriter2.vtkXMLWriter2_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x06003E3E RID: 15934
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLWriter2_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E3F RID: 15935 RVA: 0x0005AE28 File Offset: 0x00059028
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLWriter2.vtkXMLWriter2_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06003E40 RID: 15936
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLWriter2_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E41 RID: 15937 RVA: 0x0005AE48 File Offset: 0x00059048
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLWriter2.vtkXMLWriter2_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06003E42 RID: 15938
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLWriter2_GetNumberOfGhostLevels_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of ghost-levels to request from upstream pipeline.
		/// Default is 0. Note, this does not mean the output file will have as many
		/// ghost levels as requested. It's just a request. Whether the upstream
		/// pipeline can satisfy the request totally depends on the upstream pipeline
		/// itself.
		/// </summary>
		// Token: 0x06003E43 RID: 15939 RVA: 0x0005AE64 File Offset: 0x00059064
		public virtual int GetNumberOfGhostLevels()
		{
			return vtkXMLWriter2.vtkXMLWriter2_GetNumberOfGhostLevels_04(base.GetCppThis());
		}

		// Token: 0x06003E44 RID: 15940
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLWriter2_GetNumberOfGhostLevelsMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of ghost-levels to request from upstream pipeline.
		/// Default is 0. Note, this does not mean the output file will have as many
		/// ghost levels as requested. It's just a request. Whether the upstream
		/// pipeline can satisfy the request totally depends on the upstream pipeline
		/// itself.
		/// </summary>
		// Token: 0x06003E45 RID: 15941 RVA: 0x0005AE84 File Offset: 0x00059084
		public virtual int GetNumberOfGhostLevelsMaxValue()
		{
			return vtkXMLWriter2.vtkXMLWriter2_GetNumberOfGhostLevelsMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06003E46 RID: 15942
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLWriter2_GetNumberOfGhostLevelsMinValue_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of ghost-levels to request from upstream pipeline.
		/// Default is 0. Note, this does not mean the output file will have as many
		/// ghost levels as requested. It's just a request. Whether the upstream
		/// pipeline can satisfy the request totally depends on the upstream pipeline
		/// itself.
		/// </summary>
		// Token: 0x06003E47 RID: 15943 RVA: 0x0005AEA4 File Offset: 0x000590A4
		public virtual int GetNumberOfGhostLevelsMinValue()
		{
			return vtkXMLWriter2.vtkXMLWriter2_GetNumberOfGhostLevelsMinValue_06(base.GetCppThis());
		}

		// Token: 0x06003E48 RID: 15944
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLWriter2_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E49 RID: 15945 RVA: 0x0005AEC4 File Offset: 0x000590C4
		public override int IsA(string type)
		{
			return vtkXMLWriter2.vtkXMLWriter2_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06003E4A RID: 15946
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLWriter2_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E4B RID: 15947 RVA: 0x0005AEE4 File Offset: 0x000590E4
		public new static int IsTypeOf(string type)
		{
			return vtkXMLWriter2.vtkXMLWriter2_IsTypeOf_08(type);
		}

		// Token: 0x06003E4C RID: 15948
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLWriter2_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E4D RID: 15949 RVA: 0x0005AF00 File Offset: 0x00059100
		public new vtkXMLWriter2 NewInstance()
		{
			vtkXMLWriter2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLWriter2.vtkXMLWriter2_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLWriter2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003E4E RID: 15950
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLWriter2_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E4F RID: 15951 RVA: 0x0005AF5C File Offset: 0x0005915C
		public new static vtkXMLWriter2 SafeDownCast(vtkObjectBase o)
		{
			vtkXMLWriter2 vtkXMLWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLWriter2.vtkXMLWriter2_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLWriter = (vtkXMLWriter2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLWriter.Register(null);
				}
			}
			return vtkXMLWriter;
		}

		// Token: 0x06003E50 RID: 15952
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriter2_SetController_11(HandleRef pThis, HandleRef controller);

		/// <summary>
		/// Get/Set the controller to use. By default, initialized to
		/// `vtkMultiProcessController::GetGlobalController`. The controller is used to
		/// determine which piece to request from upstream.
		/// </summary>
		// Token: 0x06003E51 RID: 15953 RVA: 0x0005AFDC File Offset: 0x000591DC
		public void SetController(vtkMultiProcessController controller)
		{
			vtkXMLWriter2.vtkXMLWriter2_SetController_11(base.GetCppThis(), (controller == null) ? default(HandleRef) : controller.GetCppThis());
		}

		// Token: 0x06003E52 RID: 15954
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriter2_SetNumberOfGhostLevels_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the number of ghost-levels to request from upstream pipeline.
		/// Default is 0. Note, this does not mean the output file will have as many
		/// ghost levels as requested. It's just a request. Whether the upstream
		/// pipeline can satisfy the request totally depends on the upstream pipeline
		/// itself.
		/// </summary>
		// Token: 0x06003E53 RID: 15955 RVA: 0x0005B00B File Offset: 0x0005920B
		public virtual void SetNumberOfGhostLevels(int _arg)
		{
			vtkXMLWriter2.vtkXMLWriter2_SetNumberOfGhostLevels_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006BC RID: 1724
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLWriter2";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006BD RID: 1725
		public new static readonly string MRClassNameKey = "class vtkXMLWriter2";
	}
}
