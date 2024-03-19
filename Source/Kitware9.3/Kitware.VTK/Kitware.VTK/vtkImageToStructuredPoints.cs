using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageToStructuredPoints
	/// </summary>
	/// <remarks>
	///    Attaches image pipeline to VTK.
	///
	/// vtkImageToStructuredPoints changes an image cache format to
	/// a structured points dataset.  It takes an Input plus an optional
	/// VectorInput. The VectorInput converts the RGB scalar components
	/// of the VectorInput to vector pointdata attributes. This filter
	/// will try to reference count the data but in some cases it must
	/// make a copy.
	/// </remarks>
	// Token: 0x020009D6 RID: 2518
	public class vtkImageToStructuredPoints : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A3CE RID: 107470 RVA: 0x002461F7 File Offset: 0x002443F7
		static vtkImageToStructuredPoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageToStructuredPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageToStructuredPoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A3CF RID: 107471 RVA: 0x0024621F File Offset: 0x0024441F
		public vtkImageToStructuredPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A3D0 RID: 107472
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToStructuredPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3D1 RID: 107473 RVA: 0x00246230 File Offset: 0x00244430
		public new static vtkImageToStructuredPoints New()
		{
			vtkImageToStructuredPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToStructuredPoints.vtkImageToStructuredPoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageToStructuredPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3D2 RID: 107474 RVA: 0x00246284 File Offset: 0x00244484
		public vtkImageToStructuredPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageToStructuredPoints.vtkImageToStructuredPoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A3D3 RID: 107475 RVA: 0x002462C8 File Offset: 0x002444C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A3D4 RID: 107476
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageToStructuredPoints_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3D5 RID: 107477 RVA: 0x002462D4 File Offset: 0x002444D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageToStructuredPoints.vtkImageToStructuredPoints_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A3D6 RID: 107478
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageToStructuredPoints_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3D7 RID: 107479 RVA: 0x002462F4 File Offset: 0x002444F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageToStructuredPoints.vtkImageToStructuredPoints_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A3D8 RID: 107480
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToStructuredPoints_GetStructuredPointsOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of the filter.
		/// </summary>
		// Token: 0x0601A3D9 RID: 107481 RVA: 0x00246310 File Offset: 0x00244510
		public vtkStructuredPoints GetStructuredPointsOutput()
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToStructuredPoints.vtkImageToStructuredPoints_GetStructuredPointsOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPoints = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPoints.Register(null);
				}
			}
			return vtkStructuredPoints;
		}

		// Token: 0x0601A3DA RID: 107482
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToStructuredPoints_GetVectorInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the input object from the image pipeline.
		/// </summary>
		// Token: 0x0601A3DB RID: 107483 RVA: 0x00246380 File Offset: 0x00244580
		public vtkImageData GetVectorInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToStructuredPoints.vtkImageToStructuredPoints_GetVectorInput_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A3DC RID: 107484
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToStructuredPoints_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3DD RID: 107485 RVA: 0x002463F0 File Offset: 0x002445F0
		public override int IsA(string type)
		{
			return vtkImageToStructuredPoints.vtkImageToStructuredPoints_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601A3DE RID: 107486
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToStructuredPoints_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3DF RID: 107487 RVA: 0x00246410 File Offset: 0x00244610
		public new static int IsTypeOf(string type)
		{
			return vtkImageToStructuredPoints.vtkImageToStructuredPoints_IsTypeOf_06(type);
		}

		// Token: 0x0601A3E0 RID: 107488
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToStructuredPoints_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3E1 RID: 107489 RVA: 0x0024642C File Offset: 0x0024462C
		public new vtkImageToStructuredPoints NewInstance()
		{
			vtkImageToStructuredPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToStructuredPoints.vtkImageToStructuredPoints_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageToStructuredPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A3E2 RID: 107490
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToStructuredPoints_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3E3 RID: 107491 RVA: 0x00246488 File Offset: 0x00244688
		public new static vtkImageToStructuredPoints SafeDownCast(vtkObjectBase o)
		{
			vtkImageToStructuredPoints vtkImageToStructuredPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToStructuredPoints.vtkImageToStructuredPoints_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageToStructuredPoints = (vtkImageToStructuredPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageToStructuredPoints.Register(null);
				}
			}
			return vtkImageToStructuredPoints;
		}

		// Token: 0x0601A3E4 RID: 107492
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToStructuredPoints_SetVectorInputData_10(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set/Get the input object from the image pipeline.
		/// </summary>
		// Token: 0x0601A3E5 RID: 107493 RVA: 0x00246508 File Offset: 0x00244708
		public void SetVectorInputData(vtkImageData input)
		{
			vtkImageToStructuredPoints.vtkImageToStructuredPoints_SetVectorInputData_10(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C7C RID: 7292
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageToStructuredPoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C7D RID: 7293
		public new static readonly string MRClassNameKey = "class vtkImageToStructuredPoints";
	}
}
