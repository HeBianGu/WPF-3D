using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageAlgorithm
	/// </summary>
	/// <remarks>
	///    Generic algorithm superclass for image algs
	///
	/// vtkImageAlgorithm is a filter superclass that hides much of the
	/// pipeline complexity. It handles breaking the pipeline execution
	/// into smaller extents so that the vtkImageData limits are observed. It
	/// also provides support for multithreading. If you don't need any of this
	/// functionality, consider using vtkSimpleImageToImageFilter instead.
	/// </remarks>
	/// <seealso>
	///
	/// vtkSimpleImageToImageFilter
	/// </seealso>
	// Token: 0x0200002B RID: 43
	public class vtkImageAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000686 RID: 1670 RVA: 0x00010B54 File Offset: 0x0000ED54
		static vtkImageAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000687 RID: 1671 RVA: 0x00010B7C File Offset: 0x0000ED7C
		public vtkImageAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000688 RID: 1672 RVA: 0x00010B8A File Offset: 0x0000ED8A
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000689 RID: 1673
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAlgorithm_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0600068A RID: 1674 RVA: 0x00010B98 File Offset: 0x0000ED98
		public virtual void AddInputData(vtkDataObject arg0)
		{
			vtkImageAlgorithm.vtkImageAlgorithm_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600068B RID: 1675
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAlgorithm_AddInputData_02(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0600068C RID: 1676 RVA: 0x00010BC8 File Offset: 0x0000EDC8
		public virtual void AddInputData(int arg0, vtkDataObject arg1)
		{
			vtkImageAlgorithm.vtkImageAlgorithm_AddInputData_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600068D RID: 1677
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAlgorithm_GetImageDataInput_03(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a data object for one of the input port connections.  The use
		/// of this method is strongly discouraged, but some filters that were
		/// written a long time ago still use this method.
		/// </summary>
		// Token: 0x0600068E RID: 1678 RVA: 0x00010BF8 File Offset: 0x0000EDF8
		public vtkImageData GetImageDataInput(int port)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAlgorithm.vtkImageAlgorithm_GetImageDataInput_03(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x0600068F RID: 1679
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAlgorithm_GetInput_04(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a data object for one of the input port connections.  The use
		/// of this method is strongly discouraged, but some filters that were
		/// written a long time ago still use this method.
		/// </summary>
		// Token: 0x06000690 RID: 1680 RVA: 0x00010C68 File Offset: 0x0000EE68
		public vtkDataObject GetInput(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAlgorithm.vtkImageAlgorithm_GetInput_04(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06000691 RID: 1681
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAlgorithm_GetInput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a data object for one of the input port connections.  The use
		/// of this method is strongly discouraged, but some filters that were
		/// written a long time ago still use this method.
		/// </summary>
		// Token: 0x06000692 RID: 1682 RVA: 0x00010CD8 File Offset: 0x0000EED8
		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAlgorithm.vtkImageAlgorithm_GetInput_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06000693 RID: 1683
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageAlgorithm_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000694 RID: 1684 RVA: 0x00010D48 File Offset: 0x0000EF48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageAlgorithm.vtkImageAlgorithm_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06000695 RID: 1685
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageAlgorithm_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000696 RID: 1686 RVA: 0x00010D68 File Offset: 0x0000EF68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageAlgorithm.vtkImageAlgorithm_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06000697 RID: 1687
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAlgorithm_GetOutput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06000698 RID: 1688 RVA: 0x00010D84 File Offset: 0x0000EF84
		public vtkImageData GetOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAlgorithm.vtkImageAlgorithm_GetOutput_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06000699 RID: 1689
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAlgorithm_GetOutput_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x0600069A RID: 1690 RVA: 0x00010DF4 File Offset: 0x0000EFF4
		public vtkImageData GetOutput(int arg0)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAlgorithm.vtkImageAlgorithm_GetOutput_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x0600069B RID: 1691
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAlgorithm_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600069C RID: 1692 RVA: 0x00010E64 File Offset: 0x0000F064
		public override int IsA(string type)
		{
			return vtkImageAlgorithm.vtkImageAlgorithm_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600069D RID: 1693
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAlgorithm_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600069E RID: 1694 RVA: 0x00010E84 File Offset: 0x0000F084
		public new static int IsTypeOf(string type)
		{
			return vtkImageAlgorithm.vtkImageAlgorithm_IsTypeOf_11(type);
		}

		// Token: 0x0600069F RID: 1695
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAlgorithm_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060006A0 RID: 1696 RVA: 0x00010EA0 File Offset: 0x0000F0A0
		public new vtkImageAlgorithm NewInstance()
		{
			vtkImageAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAlgorithm.vtkImageAlgorithm_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060006A1 RID: 1697
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAlgorithm_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060006A2 RID: 1698 RVA: 0x00010EFC File Offset: 0x0000F0FC
		public new static vtkImageAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkImageAlgorithm vtkImageAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAlgorithm.vtkImageAlgorithm_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageAlgorithm = (vtkImageAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageAlgorithm.Register(null);
				}
			}
			return vtkImageAlgorithm;
		}

		// Token: 0x060006A3 RID: 1699
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAlgorithm_SetInputData_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x060006A4 RID: 1700 RVA: 0x00010F7C File Offset: 0x0000F17C
		public void SetInputData(vtkDataObject arg0)
		{
			vtkImageAlgorithm.vtkImageAlgorithm_SetInputData_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060006A5 RID: 1701
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAlgorithm_SetInputData_15(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x060006A6 RID: 1702 RVA: 0x00010FAC File Offset: 0x0000F1AC
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkImageAlgorithm.vtkImageAlgorithm_SetInputData_15(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060006A7 RID: 1703
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAlgorithm_SetOutput_16(HandleRef pThis, HandleRef d);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x060006A8 RID: 1704 RVA: 0x00010FDC File Offset: 0x0000F1DC
		public virtual void SetOutput(vtkDataObject d)
		{
			vtkImageAlgorithm.vtkImageAlgorithm_SetOutput_16(base.GetCppThis(), (d == null) ? default(HandleRef) : d.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400037E RID: 894
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400037F RID: 895
		public new static readonly string MRClassNameKey = "class vtkImageAlgorithm";
	}
}
