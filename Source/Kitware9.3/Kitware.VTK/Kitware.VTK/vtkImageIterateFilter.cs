using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageIterateFilter
	/// </summary>
	/// <remarks>
	///    Multiple executes per update.
	///
	/// vtkImageIterateFilter is a filter superclass that supports calling execute
	/// multiple times per update.  The largest hack/open issue is that the input
	/// and output caches are temporarily changed to "fool" the subclasses.  I
	/// believe the correct solution is to pass the in and out cache to the
	/// subclasses methods as arguments.  Now the data is passes.  Can the caches
	/// be passed, and data retrieved from the cache?
	/// </remarks>
	// Token: 0x0200024F RID: 591
	public class vtkImageIterateFilter : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006D6B RID: 28011 RVA: 0x0009DE43 File Offset: 0x0009C043
		static vtkImageIterateFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageIterateFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageIterateFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006D6C RID: 28012 RVA: 0x0009DE6B File Offset: 0x0009C06B
		public vtkImageIterateFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006D6D RID: 28013 RVA: 0x0009DE79 File Offset: 0x0009C079
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006D6E RID: 28014
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageIterateFilter_GetIteration_01(HandleRef pThis);

		/// <summary>
		/// Get which iteration is current being performed. Normally the
		/// user will not access this method.
		/// </summary>
		// Token: 0x06006D6F RID: 28015 RVA: 0x0009DE84 File Offset: 0x0009C084
		public virtual int GetIteration()
		{
			return vtkImageIterateFilter.vtkImageIterateFilter_GetIteration_01(base.GetCppThis());
		}

		// Token: 0x06006D70 RID: 28016
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageIterateFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D71 RID: 28017 RVA: 0x0009DEA4 File Offset: 0x0009C0A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageIterateFilter.vtkImageIterateFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06006D72 RID: 28018
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageIterateFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D73 RID: 28019 RVA: 0x0009DEC4 File Offset: 0x0009C0C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageIterateFilter.vtkImageIterateFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06006D74 RID: 28020
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageIterateFilter_GetNumberOfIterations_04(HandleRef pThis);

		/// <summary>
		/// Get which iteration is current being performed. Normally the
		/// user will not access this method.
		/// </summary>
		// Token: 0x06006D75 RID: 28021 RVA: 0x0009DEE0 File Offset: 0x0009C0E0
		public virtual int GetNumberOfIterations()
		{
			return vtkImageIterateFilter.vtkImageIterateFilter_GetNumberOfIterations_04(base.GetCppThis());
		}

		// Token: 0x06006D76 RID: 28022
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageIterateFilter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D77 RID: 28023 RVA: 0x0009DF00 File Offset: 0x0009C100
		public override int IsA(string type)
		{
			return vtkImageIterateFilter.vtkImageIterateFilter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06006D78 RID: 28024
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageIterateFilter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D79 RID: 28025 RVA: 0x0009DF20 File Offset: 0x0009C120
		public new static int IsTypeOf(string type)
		{
			return vtkImageIterateFilter.vtkImageIterateFilter_IsTypeOf_06(type);
		}

		// Token: 0x06006D7A RID: 28026
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageIterateFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D7B RID: 28027 RVA: 0x0009DF3C File Offset: 0x0009C13C
		public new vtkImageIterateFilter NewInstance()
		{
			vtkImageIterateFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageIterateFilter.vtkImageIterateFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageIterateFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006D7C RID: 28028
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageIterateFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D7D RID: 28029 RVA: 0x0009DF98 File Offset: 0x0009C198
		public new static vtkImageIterateFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageIterateFilter vtkImageIterateFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageIterateFilter.vtkImageIterateFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageIterateFilter = (vtkImageIterateFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageIterateFilter.Register(null);
				}
			}
			return vtkImageIterateFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000993 RID: 2451
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageIterateFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000994 RID: 2452
		public new static readonly string MRClassNameKey = "class vtkImageIterateFilter";
	}
}
