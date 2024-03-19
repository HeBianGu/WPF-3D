using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSimpleImageToImageFilter
	/// </summary>
	/// <remarks>
	///    Generic image filter with one input.
	///
	/// vtkSimpleImageToImageFilter is a filter which aims to avoid much
	/// of the complexity associated with vtkImageAlgorithm (i.e.
	/// support for pieces, multi-threaded operation). If you need to write
	/// a simple image-image filter which operates on the whole input, use
	/// this as the superclass. The subclass has to provide only an execute
	/// method which takes input and output as arguments. Memory allocation
	/// is handled in vtkSimpleImageToImageFilter. Also, you are guaranteed to
	/// have a valid input in the Execute(input, output) method. By default,
	/// this filter
	/// requests it's input's whole extent and copies the input's information
	/// (spacing, whole extent etc...) to the output. If the output's setup
	/// is different (for example, if it performs some sort of sub-sampling),
	/// ExecuteInformation has to be overwritten. As an example of how this
	/// can be done, you can look at vtkImageShrink3D::ExecuteInformation.
	/// For a complete example which uses templates to support generic data
	/// types, see vtkSimpleImageToImageFilter.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageAlgorithm vtkSimpleImageFilterExample
	/// </seealso>
	// Token: 0x020009E2 RID: 2530
	public abstract class vtkSimpleImageToImageFilter : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A527 RID: 107815 RVA: 0x00248B83 File Offset: 0x00246D83
		static vtkSimpleImageToImageFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimpleImageToImageFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimpleImageToImageFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A528 RID: 107816 RVA: 0x00248BAB File Offset: 0x00246DAB
		public vtkSimpleImageToImageFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A529 RID: 107817 RVA: 0x00248BB9 File Offset: 0x00246DB9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A52A RID: 107818
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimpleImageToImageFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A52B RID: 107819 RVA: 0x00248BC4 File Offset: 0x00246DC4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSimpleImageToImageFilter.vtkSimpleImageToImageFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A52C RID: 107820
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimpleImageToImageFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A52D RID: 107821 RVA: 0x00248BE4 File Offset: 0x00246DE4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSimpleImageToImageFilter.vtkSimpleImageToImageFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A52E RID: 107822
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleImageToImageFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A52F RID: 107823 RVA: 0x00248C00 File Offset: 0x00246E00
		public override int IsA(string type)
		{
			return vtkSimpleImageToImageFilter.vtkSimpleImageToImageFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601A530 RID: 107824
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleImageToImageFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A531 RID: 107825 RVA: 0x00248C20 File Offset: 0x00246E20
		public new static int IsTypeOf(string type)
		{
			return vtkSimpleImageToImageFilter.vtkSimpleImageToImageFilter_IsTypeOf_04(type);
		}

		// Token: 0x0601A532 RID: 107826
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleImageToImageFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A533 RID: 107827 RVA: 0x00248C3C File Offset: 0x00246E3C
		public new vtkSimpleImageToImageFilter NewInstance()
		{
			vtkSimpleImageToImageFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleImageToImageFilter.vtkSimpleImageToImageFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleImageToImageFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A534 RID: 107828
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleImageToImageFilter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A535 RID: 107829 RVA: 0x00248C98 File Offset: 0x00246E98
		public new static vtkSimpleImageToImageFilter SafeDownCast(vtkObjectBase o)
		{
			vtkSimpleImageToImageFilter vtkSimpleImageToImageFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleImageToImageFilter.vtkSimpleImageToImageFilter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimpleImageToImageFilter = (vtkSimpleImageToImageFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimpleImageToImageFilter.Register(null);
				}
			}
			return vtkSimpleImageToImageFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C94 RID: 7316
		public new const string MRFullTypeName = "Kitware.VTK.vtkSimpleImageToImageFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C95 RID: 7317
		public new static readonly string MRClassNameKey = "class vtkSimpleImageToImageFilter";
	}
}
